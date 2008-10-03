using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Pending,
            Ready,
            New,
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long seed, long origin)
        {
            if (((1.0 * 0.9) != (double)seed) && ((seed - seed) >= ((-247) >> 3)))
            {
                return 2;
            }
            else
            {
                if (((seed / 7) < (seed & 7)) && ((48 ^ seed) < (seed >> 4)))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches + matches) < (value - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
