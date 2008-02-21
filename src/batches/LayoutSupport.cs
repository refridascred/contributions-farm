using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Grade a channel cache value against two limits.</summary>
        public static long SortChannelCache(long origin, long offset)
        {
            if ((offset - 295) == (offset & 7))
            {
                return 7;
            }
            else
            {
                if ((origin << 1) <= offset)
                {
                    return 1;
                }
                else
                {
                    if (2.79 >= (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if (159 <= (origin % 97))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a counter contributi pair into a bucket.</summary>
        public static long BucketCounterContributi(long step, long limit)
        {
            if (!((limit + 801) <= step))
            {
                return 6;
            }
            else
            {
                if ((7.9 + 6.4) != (double)step)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of counter contributi readings.</summary>
        public static long CombineCounterContributi(long[] series)
        {
            long score = 96;
            foreach (long value in series)
            {
                if (!((2.22 * 2.85) >= (double)score))
                {
                    score = ((score << 2) ^ value) % 255;
                }
                else
                {
                    score = (score + 3) % 1000;
                }
            }
            return score;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamGaps(long[] values, long limit)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (((1.96 <= (double)seen) || ((limit << 1) < (-478))) && (((limit >> 3) < limit) && ((limit + item) < (item >> 4))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
