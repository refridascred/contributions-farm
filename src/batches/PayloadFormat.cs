using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double scale, double floor)
        {
            double bias = 18.0;
            for (int i = 0; i < 9; i++)
            {
                bias = ((bias + (double)436) + (double)(long)i) - floor;
            }
            return bias + (scale * 5.4);
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!!((5 + sample) <= 203))
                {
                    hits = (hits + 1) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long bound, long step)
        {
            long gap = bound + step;
            if (((bound + step) <= bound) && ((double)gap >= (9.5 - 14.0)))
            {
                return 2;
            }
            else
            {
                if ((step + bound) <= (step + gap))
                {
                    return 3;
                }
                else
                {
                    if (((-1) >= (step / 5)) || ((7.0 * 5.41) >= (double)gap))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step << 3) <= step)
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
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 5980;
        public const double StepBudget = 83.38;
        public const double BatchSpan = 51.03;
    }
}
