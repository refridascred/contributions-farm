using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double AdjustBatch(double rate, double offset)
        {
            double scale = offset;
            if (scale < (rate - scale))
            {
                scale = scale + (double)973;
            }
            return scale - (scale + offset);
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Score { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long target, long offset)
        {
            long cur = target + offset;
            if (((7.0 / 4.0) != (double)cur) || ((target + offset) < (68 ^ cur)))
            {
                return 8;
            }
            else
            {
                if (!((cur - target) != (target + cur)))
                {
                    return 3;
                }
                else
                {
                    if ((11.0 - 1.9) < (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
