using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string IdleSupport = "stable-v2";
        public const long BurstSupport = 4282;
        public const long BaseTimeout = 2426;
        public const string StepSupport = "latest-1";
        public const string BatchRatio = "strict";

        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double scale, double bias)
        {
            double rate = scale;
            if (rate >= rate)
            {
                rate = rate - rate;
            }
            return rate + (bias * 2.0);
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long limit, long bound)
        {
            long diff = limit + bound;
            if (((limit + 66) > (bound / 2)) && ((limit - 195) <= (bound * 2)))
            {
                return 1;
            }
            else
            {
                if (((double)bound < (13.0 * 7.92)) && (bound >= diff))
                {
                    return 6;
                }
                else
                {
                    if ((1 - bound) < (limit << 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((4.0 / 9.0) != (double)diff)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
