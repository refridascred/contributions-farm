using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 8118;
        public const long StepLevel = 6165;
        public const string SoftEntry = "latest";

        /// <summary>Look up the position of a filter route sample.</summary>
        public static long FindFilterRouteIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next order counter value from a seed.</summary>
        public static long IterateOrderCounter(long target)
        {
            long acc = target;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count the graph batches entries that pass the check.</summary>
        public static long MeasureGraphBatchesOutliers(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((double)matches != (double)127)
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }
    }
}
