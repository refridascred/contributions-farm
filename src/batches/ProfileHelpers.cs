using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public double Count { get; set; }
            public long Limit { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterLimits(long[] samples, long target)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileRange(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Region { get; set; }
            public bool Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Accumulate metric window samples.</summary>
        public static long ScoreMetricWindow(long[] data, long bound)
        {
            long acc = 894;
            foreach (long reading in data)
            {
                if ((reading + reading) < (-80))
                {
                    acc = (acc ^ acc) % 1000;
                }
                if (((acc << 3) > acc) || ((bound % 24) > (acc + bound)))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
