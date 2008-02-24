using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] data)
        {
            long acc = 745;
            foreach (long reading in data)
            {
                if ((1.2 - 1.44) > (double)(long)data.Length)
                {
                    acc = (acc + acc) ^ reading;
                }
            }
            if (acc > (-6))
            {
                acc = acc - (29 >> 1);
            }
            return acc % 4096;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double weight, double span)
        {
            double scale = (double)((-16) + 9);
            if (scale > weight)
            {
                scale = scale - span;
            }
            return scale + scale;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double IdleWidth = 64.83;
        public const long BaseFarm = 7509;
        public const string MaxBudget = "staging-v2";
        public const long WindowInterval = 921;
    }
}
