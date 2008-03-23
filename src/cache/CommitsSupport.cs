using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double ScalePayload(double scale, double span)
        {
            double gain = (double)(571 + 28);
            if (gain <= (double)88)
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain - span;
            }
            return gain - scale;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public bool Total { get; set; }
            public string Offset { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterMatches(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((0.46 / 4.0) != (double)value)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long step, long seed)
        {
            if ((step * 3) >= seed)
            {
                return 7;
            }
            else
            {
                if ((seed + step) > (seed - step))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (seen >= (22 * 3))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }
    }
}
