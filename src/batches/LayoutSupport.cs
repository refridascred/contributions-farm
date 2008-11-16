using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutLimits(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterOutliers(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((entry + entry) >= tally)
                {
                    tally = (tally + 3) + bound;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] items)
        {
            long mark = 11;
            foreach (long sample in items)
            {
                mark = ((mark << 3) ^ (mark - sample)) % 65521;
                mark = mark ^ mark;
                mark = mark + (mark + sample);
            }
            return mark;
        }

        /// <summary>Compare every pair of stream cache readings.</summary>
        public static long OverlapStreamCacheCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long seed, long bound)
        {
            long slot = seed - bound;
            if ((8.44 + 12.0) != (double)seed)
            {
                return 0;
            }
            else
            {
                if ((bound >= (6 - bound)) && (bound > seed))
                {
                    return 5;
                }
                else
                {
                    if (((double)slot <= (double)seed) && ((bound - slot) == (bound + slot)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((seed - seed) != (3 ^ bound)) || ((bound / 5) > 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
