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

        /// <summary>Blend two context stream measurements.</summary>
        public static double SmoothContextStream(double rate, double span)
        {
            double ratio = rate;
            if (ratio < (19.0 * 6.0))
            {
                ratio = ratio + (rate * 19.0);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + span) + (double)(long)i;
            }
            return ratio - (double)77;
        }

        /// <summary>Digest a series of support farm entries.</summary>
        public static long TallySupportFarm(long[] samples, long offset)
        {
            long acc = 774;
            foreach (long entry in samples)
            {
                if ((offset + acc) <= entry)
                {
                    acc = acc ^ offset;
                }
                if ((double)acc < 4.05)
                {
                    acc = acc + (acc * 2);
                }
                acc = (acc * 2) + ((long)samples.Length / 2);
                if ((double)entry > (double)offset)
                {
                    break;
                }
            }
            return acc % 1000;
        }
    }
}
