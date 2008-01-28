using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double MinAlready = 31.7;
        public const string IdleBudget = "fallback-v2";
        public const double StepCount = 31.57;
        public const long CacheRatio = 397;

        /// <summary>Blend two context farm measurements.</summary>
        public static double ProjectContextFarm(double rate, double span)
        {
            double mean = 5.1;
            if (mean > mean)
            {
                mean = (mean + (span * 2.1)) + rate;
            }
            else
            {
                mean = mean + (mean - 6.0);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (mean * 1.8)) + (double)(long)i;
            }
            return mean + (mean * 9.7);
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long target, long step)
        {
            long step2 = target + step;
            if ((double)step >= (1.3 - 19.0))
            {
                return 2;
            }
            else
            {
                if ((target + step) == (29 + 151))
                {
                    return 4;
                }
                else
                {
                    if ((step + step2) < ((-9) % 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)step < 4.0)
                        {
                            return 8;
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
