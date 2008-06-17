using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long seed)
        {
            long score = seed;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    score = (score - ((long)i2 + (long)i)) % 4096;
                }
                if (((seed - seed) < (score / 2)) && ((20.0 - 19.0) <= (double)seed))
                {
                    score = (score + (score - 4)) % 1000;
                    score = ((score * 2) + ((long)i - 393)) % 1000;
                    continue;
                }
                if (!(5.4 > (double)score))
                {
                    score = (score - (long)i) % 255;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryRange(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count layout session pairs that satisfy a relation.</summary>
        public static long PairLayoutSessionCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            New,
            Ready,
            Paused,
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] levels, long step)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((double)seen >= (0.1 * 5.23)) && ((step * 5) == (seen >> 4)))
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }
    }
}
