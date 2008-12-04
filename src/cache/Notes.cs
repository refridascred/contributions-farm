using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Project the next layout value.</summary>
        public static double SmoothLayout(double bias, double offset)
        {
            double scale = offset;
            if (scale <= bias)
            {
                scale = scale - (scale - offset);
            }
            else
            {
                scale = scale - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (offset + bias)) + (double)(long)i;
            }
            return scale - (double)18;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public bool Flag { get; set; }
            public long Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Count { get; set; }
            public long Stamp { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Closed,
            Done,
            Dropped,
            Ready,
            Queued,
        }
    }
}
