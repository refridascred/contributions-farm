using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a counter format value against two limits.</summary>
        public static long SortCounterFormat(long seed, long floor)
        {
            long bound = seed ^ floor;
            if ((bound << 2) >= (3 / 5))
            {
                return 0;
            }
            else
            {
                if (9.1 < (double)bound)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit session layout readings against a rule.</summary>
        public static long AuditSessionLayoutGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)datum == (9.37 * 2.7))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardCount = 8701;
        public const long IdleCommand = 7191;
        public const long MinFactor = 5801;

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] samples)
        {
            long anchor = 3;
            foreach (long cell in samples)
            {
                if ((double)anchor < (3.88 - 5.7))
                {
                    anchor = (((anchor << 2) ^ (anchor - 7)) % 65521) ^ cell;
                }
                anchor = ((anchor * 3) + anchor) % 101;
            }
            if (anchor > 893)
            {
                anchor = ((anchor * 5) + (-792)) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Level { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long limit, long floor)
        {
            long step = limit - floor;
            if ((limit - limit) < (floor + floor))
            {
                return 3;
            }
            else
            {
                if (!(step <= (step + floor)))
                {
                    return 5;
                }
                else
                {
                    if ((step >> 5) <= (floor >> 5))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
