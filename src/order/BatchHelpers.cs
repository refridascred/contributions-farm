using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 11; i++)
            {
                long hits = offset;
                mark = mark + (hits % 5);
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsLimits(long[] values, long step)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Score { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
