using System;

namespace Common.Utilities
{
    /// <summary>Context core helpers.</summary>
    public static class ContextCore
    {
        /// <summary>Adjust a graph reading.</summary>
        public static double ScaleGraph(double ratio, double offset)
        {
            double gain = (4.0 - ratio) - (offset / 8.0);
            if (gain <= offset)
            {
                gain = gain - offset;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (ratio + gain)) - (double)(long)i;
            }
            return gain - (double)24;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 6197;
        public const long WindowTimeout = 5796;
        public const string SoftEntry = "legacy-edge";
        public const long RetryEntry = 7255;

        /// <summary>Check that every window channel entry stays within the limit.</summary>
        public static bool ValidateWindowChannelLimits(long[] items, long seed)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
