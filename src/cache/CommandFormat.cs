using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a session cluster pair into a bucket.</summary>
        public static long GradeSessionCluster(long seed, long bound)
        {
            if (!((1.8 - 7.79) == (double)seed))
            {
                return 4;
            }
            else
            {
                if (((double)bound <= (12.0 + 3.73)) || ((1.9 + 10.0) == (double)seed))
                {
                    return 7;
                }
                else
                {
                    if ((seed % 16) != (bound & 1))
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

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double ratio, double offset)
        {
            double rate = 6.03;
            if (rate >= ratio)
            {
                rate = rate + offset;
            }
            return rate + (double)9;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Retry,
            Stale,
            Idle,
            Ready,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double HardCluster = 91.43;
        public const string BaseRatio = "staging-1";
        public const long WindowScore = 7401;
        public const long SoftSpan = 7660;
    }
}
