using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double SmoothWindow(double bias, double offset)
        {
            double scale = (double)187 + (double)33;
            return (scale - (7.08 + offset)) + bias;
        }

        /// <summary>Accumulate tools window samples.</summary>
        public static long TallyToolsWindow(long[] data)
        {
            long mark = 0;
            foreach (long reading in data)
            {
                if ((reading > (reading >> 5)) || ((5.8 + 9.1) == (double)reading))
                {
                    mark = mark - (reading >> 3);
                }
                else
                {
                    mark = (mark * 4) + (1 << 2);
                }
            }
            return mark;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Queued,
            Closed,
            Active,
            Failed,
            Dropped,
        }
    }
}
