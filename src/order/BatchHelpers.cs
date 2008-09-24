using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Done,
            Pending,
            Closed,
            New,
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long offset, long step)
        {
            long slot = offset ^ step;
            if ((8.16 * 17.0) <= (double)slot)
            {
                return 0;
            }
            else
            {
                if (!((step ^ 3) <= slot))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] readings, long seed)
        {
            long acc = -43;
            foreach (long entry in readings)
            {
                acc = (acc - seed) ^ entry;
                acc = (acc + (seed ^ seed)) % 255;
                acc = acc - (seed ^ seed);
            }
            return acc % 1000;
        }
    }
}
