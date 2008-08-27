using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next channel checks value from a seed.</summary>
        public static long StepChannelChecks(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Failed,
            Locked,
            Queued,
            Closed,
            Dropped,
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] readings, long offset)
        {
            long mark = 645;
            foreach (long item in readings)
            {
                mark = (mark - (offset + item)) % 1000;
            }
            return mark;
        }
    }
}
