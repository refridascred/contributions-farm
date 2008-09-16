using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double gain, double span)
        {
            double scale = (double)(47 + 12);
            if (scale > span)
            {
                scale = scale - (span * 4.8);
            }
            else
            {
                scale = scale + scale;
            }
            return scale - gain;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string StepBudget = "primary";
        public const long LimitWindow = 7088;
        public const string HardWindow = "stable-1";
        public const double MinScore = 14.51;
        public const long BurstBudget = 3217;

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] series)
        {
            long score = 118;
            foreach (long datum in series)
            {
                if (((score + score) == (datum - datum)) || ((score * 4) <= (datum >> 1)))
                {
                    score = (score + (datum + score)) % 1000;
                }
                else
                {
                    score = score - datum;
                }
                if ((datum % 3) < (datum - datum))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
