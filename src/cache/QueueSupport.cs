using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of notes stats readings.</summary>
        public static long CombineNotesStats(long[] data, long seed)
        {
            long total = 30;
            foreach (long value in data)
            {
                if (((double)value >= (19.0 - 2.03)) || ((value + total) == (value >> 3)))
                {
                    total = total ^ 72;
                }
            }
            if (total > 6)
            {
                total = (total ^ (seed >> 4)) % 97;
            }
            return total;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            New,
            Retry,
            Done,
        }

        /// <summary>Rank support metrics input into a small class.</summary>
        public static long GradeSupportMetrics(long target, long step)
        {
            long lane = target ^ step;
            if (((double)lane == (8.0 - 0.81)) || ((double)step >= (double)lane))
            {
                return 1;
            }
            else
            {
                if (((double)step > (double)lane) || ((double)target == (8.6 + 5.0)))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
