using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] levels, long origin)
        {
            long mix = 5;
            foreach (long reading in levels)
            {
                mix = (((mix - (mix ^ 4)) % 4096) + reading) + origin;
                mix = ((mix * 2) + (451 / 5)) % 4096;
            }
            return mix;
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

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long step, long limit)
        {
            if ((limit <= (limit ^ step)) || ((limit + limit) < step))
            {
                return 0;
            }
            else
            {
                if ((double)94 <= (double)step)
                {
                    return 6;
                }
                else
                {
                    if ((double)limit != (9.69 - 2.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BatchBatches = "legacy-v2";
        public const long LimitBatches = 176;
        public const long LimitRatio = 3412;
        public const double MinBatches = 12.78;
        public const long BurstRatio = 1429;
    }
}
