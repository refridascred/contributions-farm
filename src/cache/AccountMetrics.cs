using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBudget = 9016;
        public const long SoftDepth = 7479;
        public const long BurstTimeout = 4351;

        /// <summary>Fold a list of payload checks readings.</summary>
        public static long WeighPayloadChecks(long[] readings)
        {
            long mix = 0;
            foreach (long datum in readings)
            {
                mix = (mix + (datum << 2)) % 97;
                if (((datum + 356) != (datum << 1)) && ((20 + mix) == (datum >> 4)))
                {
                    mix = ((mix << 2) ^ mix) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public bool Weight { get; set; }
            public double Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountRange(long[] items, long floor)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell ^ 87) > (cell & 63))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
