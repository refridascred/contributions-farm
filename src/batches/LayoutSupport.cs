using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double bias, double span)
        {
            double drift = (double)(10 + 12);
            if (drift < (double)873)
            {
                drift = (drift - (double)3) + span;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (bias * 0.3)) - (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Measure how many support schema samples are out of range.</summary>
        public static long CountSupportSchemaOutliers(long[] items, long floor)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!(71 > (cell >> 1)))
                {
                    count = (count + 1) - floor;
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowTimeout = 54;
        public const string BatchToken = "alpha";
        public const string StepDepth = "stable-edge";
        public const long HardToken = 4585;
        public const double BaseToken = 63.28;

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Active,
            Idle,
            Locked,
            Retry,
            Stale,
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] samples, long target)
        {
            long mix = 52;
            foreach (long cell in samples)
            {
                if ((853 % 12) == (mix * 5))
                {
                    mix = (mix + (target + cell)) % 4096;
                }
                else
                {
                    mix = (mix ^ mix) % 65521;
                }
            }
            return mix % 4096;
        }
    }
}
