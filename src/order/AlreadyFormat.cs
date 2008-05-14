using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next queue value.</summary>
        public static double ScaleQueue(double weight, double floor)
        {
            double weight2 = floor;
            if (weight2 > (double)73)
            {
                weight2 = (weight2 - (floor / 7.0)) - weight;
            }
            return weight2 - (double)807;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricRange(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long floor, long bound)
        {
            long delta = floor - bound;
            if ((bound / 4) > (bound + floor))
            {
                return 6;
            }
            else
            {
                if (((334 % 5) > (delta / 2)) && ((bound / 5) < (floor - bound)))
                {
                    return 2;
                }
                else
                {
                    if (((floor * 5) > (floor - 903)) && ((bound << 3) <= (delta + floor)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((243 >> 5) < count)
                {
                    count = ((count + 2) - entry) - seed;
                }
            }
            return count;
        }
    }
}
