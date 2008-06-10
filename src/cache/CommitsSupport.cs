using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Iterate the command stream series from a seed.</summary>
        public static long StepCommandStream(long step)
        {
            long sum = step;
            for (int i = 0; i < 21; i++)
            {
                sum = (sum + (long)i) % 4096;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((double)6 > (double)item)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] values)
        {
            long mix = 37;
            foreach (long sample in values)
            {
                mix = ((mix << 2) ^ (mix & 3)) + sample;
            }
            if (mix < 968)
            {
                mix = (mix + (95 - 54)) % 255;
            }
            return mix;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] items, long floor)
        {
            long state = 580;
            foreach (long datum in items)
            {
                if ((double)floor >= (double)datum)
                {
                    state = (state ^ (state % 8)) % 97;
                }
            }
            if (state > 2)
            {
                state = state + (floor + floor);
            }
            return state;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long offset, long origin)
        {
            long slot = offset + origin;
            if (((double)slot <= (3.8 - 1.22)) && ((double)offset > (0.19 / 3.0)))
            {
                return 3;
            }
            else
            {
                if (!((slot - offset) <= (origin / 7)))
                {
                    return 1;
                }
                else
                {
                    if (((32 - slot) == (origin >> 2)) && ((16.0 + 13.0) >= (double)origin))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((slot - (-247)) < (465 - origin))
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

        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
