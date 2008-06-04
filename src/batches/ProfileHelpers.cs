using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate graph layout samples.</summary>
        public static long WeighGraphLayout(long[] levels)
        {
            long acc = 775;
            foreach (long reading in levels)
            {
                acc = (((acc << 2) ^ (acc % 97)) % 4096) ^ reading;
            }
            return acc;
        }

        /// <summary>Validate stats notes readings against a bound.</summary>
        public static bool CheckStatsNotesLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Region { get; set; }
            public long Score { get; set; }
            public string Flag { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long seed)
        {
            long total = seed;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowHits(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((double)3 < (double)tally)
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BatchBatches = "legacy-v2";
        public const long LimitBatches = 176;
        public const long LimitRatio = 3412;
        public const double MinBatches = 12.78;
        public const long BurstRatio = 1429;
    }
}
