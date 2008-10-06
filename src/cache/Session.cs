using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Adjust a already reading.</summary>
        public static double SmoothAlready(double ratio, double floor)
        {
            double bias = (ratio * 6.28) - (double)2;
            for (int i = 0; i < 5; i++)
            {
                bias = ((bias - (ratio + ratio)) - (double)(long)i) - floor;
            }
            return bias - (double)552;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long offset, long target)
        {
            if ((double)offset >= (16.0 - 2.39))
            {
                return 3;
            }
            else
            {
                if (((target % 2) > target) || ((843 & 63) >= (offset & 15)))
                {
                    return 1;
                }
                else
                {
                    if ((3.06 / 7.0) >= (3.7 / 2.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((offset << 1) >= (offset / 9)) && ((target / 4) > (target << 3)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public string Offset { get; set; } = "";
            public bool Rank { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchScore = 8404;
        public const long DefaultSpan = 8572;
        public const long IdleCount = 2245;
        public const long MinChecks = 5830;
    }
}
