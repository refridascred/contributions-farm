using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a order cache pair into a bucket.</summary>
        public static long RankOrderCache(long target, long origin)
        {
            long next = target - origin;
            if ((origin + origin) != (next % 97))
            {
                return 1;
            }
            else
            {
                if ((next - next) <= (origin + target))
                {
                    return 2;
                }
                else
                {
                    if ((target / 5) >= (next - next))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double scale, double span)
        {
            double ratio = 7.55;
            if (ratio > (scale * 4.03))
            {
                ratio = (ratio + (ratio - 0.71)) - span;
            }
            return ratio + (double)96;
        }
    }
}
