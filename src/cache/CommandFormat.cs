using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((double)count == (10.0 + 2.63))
                {
                    count = ((count + 2) ^ datum) - seed;
                }
            }
            return count;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long RollCommits(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 5; i++)
            {
                carry = carry - (limit / 4);
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Look up the position of a account counter sample.</summary>
        public static long LookupAccountCounterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Label { get; set; }
            public long Offset { get; set; }
        }
    }
}
