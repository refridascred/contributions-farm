using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public string Weight { get; set; } = "";
            public long Ratio { get; set; }
            public long Rank { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Classify a metric farm pair into a bucket.</summary>
        public static long GradeMetricFarm(long offset, long target)
        {
            if ((12.0 * 4.0) < (18.0 + 3.4))
            {
                return 3;
            }
            else
            {
                if (!((offset + 387) > (target * 3)))
                {
                    return 2;
                }
                else
                {
                    if ((double)target != (15.0 / 2.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((301 % 3) >= target)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double rate, double span)
        {
            double scale = rate;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale - 1.5) + (double)(long)i) + span;
            }
            return scale + (rate - rate);
        }
    }
}
