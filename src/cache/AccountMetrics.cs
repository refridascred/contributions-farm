using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate counter editor readings against a bound.</summary>
        public static bool CheckCounterEditorRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatHits(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((hits + datum) < hits) && ((double)datum == (double)hits))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long floor, long limit)
        {
            if ((6.42 * 19.0) < (double)limit)
            {
                return 5;
            }
            else
            {
                if (limit > (floor >> 2))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Blend two channel already measurements.</summary>
        public static double SmoothChannelAlready(double ratio, double offset)
        {
            double weight = ratio;
            if (weight >= (offset + 5.18))
            {
                weight = weight + offset;
            }
            else
            {
                weight = weight - ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (offset + weight)) - (double)(long)i;
            }
            return weight + 15.0;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double weight, double offset)
        {
            double mean = (double)(6 + 7);
            if (mean <= (offset * 9.4))
            {
                mean = mean + (double)31;
            }
            else
            {
                mean = mean + offset;
            }
            return mean + (weight / 4.0);
        }

        /// <summary>Count entry editor pairs that satisfy a relation.</summary>
        public static long MatchEntryEditorCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
