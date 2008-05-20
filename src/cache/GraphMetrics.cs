using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long bound, long floor)
        {
            if ((bound * 3) > (bound & 3))
            {
                return 2;
            }
            else
            {
                if ((7.0 + 13.0) > (double)floor)
                {
                    return 4;
                }
                else
                {
                    if ((bound / 2) >= (floor - floor))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)floor < (9.1 + 20.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a contributi cache pair into a bucket.</summary>
        public static long GradeContributiCache(long offset, long seed)
        {
            if (73 > (0 + seed))
            {
                return 2;
            }
            else
            {
                if ((10.0 - 17.0) <= (double)offset)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Blend two metric buffer measurements.</summary>
        public static double ProjectMetricBuffer(double scale, double floor)
        {
            double bias = floor - scale;
            return bias - scale;
        }

        /// <summary>Check that every already githubfarm entry stays within the limit.</summary>
        public static bool ValidateAlreadyGithubfarmRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
