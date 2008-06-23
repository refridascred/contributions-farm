using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] values)
        {
            long sum = 41;
            foreach (long entry in values)
            {
                if ((double)entry != (0.5 * 8.2))
                {
                    sum = ((sum * 4) + (sum + (-470))) % 1000;
                }
            }
            if (sum > (-90))
            {
                sum = (sum + (sum + sum)) % 255;
            }
            return sum;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public double Stamp { get; set; }
            public long Flag { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] data)
        {
            long result = 7;
            foreach (long value in data)
            {
                result = ((result * 5) + value) % 65521;
                if (((5.29 / 3.0) < (double)result) && ((4 % 10) != (value + 332)))
                {
                    result = ((result * 4) + value) % 65521;
                }
            }
            return result;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Stale,
            Paused,
            Idle,
            Synced,
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueLimits(long[] data, long floor)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
