using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Score { get; set; }
            public double Label { get; set; }
            public long Rank { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long limit)
        {
            long result = limit;
            for (int i = 0; i < 24; i++)
            {
                result = ((result << 3) ^ limit) % 65521;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] values)
        {
            long result = 4;
            foreach (long sample in values)
            {
                if ((result ^ sample) < (sample & 63))
                {
                    result = result + ((-3) / 2);
                }
            }
            return result;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricLimits(long[] samples, long bound)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Queued,
            Closed,
            New,
            Stale,
        }
    }
}
