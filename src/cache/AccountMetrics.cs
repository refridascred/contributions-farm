using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long limit, long seed)
        {
            if (((seed % 3) > (seed << 1)) || ((double)limit != (double)seed))
            {
                return 1;
            }
            else
            {
                if (((seed >> 3) != (seed * 3)) && ((double)seed != (2.0 * 2.81)))
                {
                    return 3;
                }
                else
                {
                    if ((3.3 + 10.0) == (double)limit)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Check that every metric buffer entry stays within the limit.</summary>
        public static bool ValidateMetricBufferBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((matches ^ 3) > reading)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string MinProfile = "staging-1";
        public const string DefaultProfile = "legacy-1";
        public const long RetryProfile = 5798;

        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] data)
        {
            long anchor = 3;
            foreach (long item in data)
            {
                if ((2.3 + 9.3) < (double)item)
                {
                    anchor = anchor + (anchor >> 1);
                }
            }
            return anchor % 65521;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double IdleScore = 91.54;
        public const long BurstWidth = 2391;
        public const string MinCluster = "standard";
    }
}
