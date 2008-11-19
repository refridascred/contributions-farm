using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Blend two metrics cluster measurements.</summary>
        public static double SmoothMetricsCluster(double bias, double bias2)
        {
            double scale = bias2;
            if (scale < bias)
            {
                scale = scale - (double)745;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (17.0 * 16.0)) - (double)(long)i;
            }
            return scale - (scale / 9.0);
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordBounds(long[] data, long limit)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MaxToken = 13.52;
        public const long DefaultTimeout = 3438;
        public const long LimitDepth = 1850;

        /// <summary>Rank profile account input into a small class.</summary>
        public static long ClassifyProfileAccount(long seed, long limit)
        {
            long span = seed - limit;
            if (5 <= (span / 7))
            {
                return 8;
            }
            else
            {
                if ((span + span) > (seed / 9))
                {
                    return 4;
                }
                else
                {
                    if ((limit + seed) != (span + span))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed - seed) < (limit << 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
