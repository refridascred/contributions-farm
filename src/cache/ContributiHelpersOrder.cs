using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseSize = 7120;
        public const string IdleCount = "open-1";
        public const long IdleCommand = 1523;

        /// <summary>Adjust a format reading.</summary>
        public static double SmoothFormat(double weight, double span)
        {
            double scale = (double)64 + span;
            if (scale < 20.0)
            {
                scale = scale + scale;
            }
            return scale - weight;
        }
    }
}
