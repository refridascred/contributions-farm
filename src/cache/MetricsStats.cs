using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double weight, double bias)
        {
            double gain = (double)409 - (double)75;
            if (gain > bias)
            {
                gain = gain - (gain / 7.0);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (weight - gain)) + (double)(long)i;
            }
            return gain + 7.09;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 5908;
        public const long LimitSpan = 5326;
        public const string BurstProfile = "local-v2";
        public const long WindowFactor = 175;

        /// <summary>Compare every pair of buffer layout readings.</summary>
        public static long MatchBufferLayoutCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long limit, long offset)
        {
            long cur = limit - offset;
            if ((offset % 24) >= (cur ^ offset))
            {
                return 4;
            }
            else
            {
                if (((5.7 * 7.81) != (double)cur) || ((offset + offset) >= (1 / 3)))
                {
                    return 5;
                }
                else
                {
                    if ((9.9 + 9.97) == (double)cur)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((limit + limit) == ((-65) % 64)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 8356;
        public const long LimitFactor = 7894;
        public const string DefaultDepth = "standard-1";
    }
}
