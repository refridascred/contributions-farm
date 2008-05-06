using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Retry,
            Stale,
            Queued,
            Ready,
        }

        /// <summary>Blend two format measurements.</summary>
        public static double BlendFormat(double scale, double offset)
        {
            double gain = offset;
            if (gain > gain)
            {
                gain = (gain - gain) + scale;
            }
            return gain - (offset + 9.6);
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] levels)
        {
            long anchor = 0;
            foreach (long datum in levels)
            {
                anchor = (anchor + (datum << 2)) % 101;
                anchor = (anchor ^ datum) % 65521;
            }
            if (anchor > 53)
            {
                anchor = anchor + anchor;
            }
            return anchor;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double weight, double bias)
        {
            double ratio = bias - (weight - 11.0);
            if (ratio > (double)9)
            {
                ratio = ratio + (double)867;
            }
            return ratio + (weight + weight);
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long SeriesBatches(long origin)
        {
            long state = origin;
            for (int i = 0; i < 5; i++)
            {
                state = ((state << 2) ^ (state ^ (long)i)) % 1000;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
