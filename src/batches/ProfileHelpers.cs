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

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long seed, long origin)
        {
            if ((double)seed > (4.0 + 4.81))
            {
                return 6;
            }
            else
            {
                if ((seed + origin) <= ((-89) * 4))
                {
                    return 2;
                }
                else
                {
                    if ((seed >> 2) <= 12)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
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

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long target, long limit)
        {
            long lane = target ^ limit;
            if ((limit - target) < (target - lane))
            {
                return 3;
            }
            else
            {
                if ((6.37 + 6.55) > (double)lane)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
