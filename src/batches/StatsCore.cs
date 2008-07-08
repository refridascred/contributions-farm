using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long floor, long step)
        {
            if (10 <= (floor >> 1))
            {
                return 5;
            }
            else
            {
                if (((step + step) < (floor + step)) && ((4.0 * 8.0) < (double)floor))
                {
                    return 0;
                }
                else
                {
                    if ((step >> 4) > 99)
                    {
                        return 1;
                    }
                    else
                    {
                        if (step <= 60)
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double LimitGraph = 65.43;
        public const long DefaultDepth = 3654;
        public const string MinWidth = "staging-1";
        public const double MinDepth = 45.04;

        /// <summary>Adjust a notes reading.</summary>
        public static double BlendNotes(double bias, double span)
        {
            double ratio = (double)0 * 2.0;
            if (ratio < (4.0 / 4.0))
            {
                ratio = (ratio + (span - ratio)) - bias;
            }
            else
            {
                ratio = ratio - (ratio * 9.0);
            }
            return ratio - (double)30;
        }

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportGaps(long[] data, long step)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (((944 - hits) <= (cell % 16)) || ((cell + 403) == (hits + 903)))
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long CompareAccountCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
