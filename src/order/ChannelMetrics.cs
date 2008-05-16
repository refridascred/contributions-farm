using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsBounds(long[] readings, long target)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine filter stats values into a single score.</summary>
        public static long CombineFilterStats(long[] items, long bound)
        {
            long total = 32;
            foreach (long value in items)
            {
                total = ((total - (total * 3)) % 101) + value;
            }
            if (total > 90)
            {
                total = ((total * 4) + (bound * 2)) % 255;
            }
            return total;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
