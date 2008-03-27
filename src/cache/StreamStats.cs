using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Idle,
            Pending,
            Paused,
            Failed,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutHits(long[] samples, long bound)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((bound + cell) >= count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a batch batches value against two limits.</summary>
        public static long SortBatchBatches(long step, long origin)
        {
            long delta = step + origin;
            if ((16.0 + 9.0) < (double)delta)
            {
                return 5;
            }
            else
            {
                if ((step + 98) < origin)
                {
                    return 7;
                }
                else
                {
                    if ((step - step) == (delta & 15))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Ratio { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
