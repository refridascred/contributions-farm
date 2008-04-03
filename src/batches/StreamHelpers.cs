using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Mode { get; set; }
            public bool Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Retry,
            Draft,
            Failed,
            Queued,
        }

        /// <summary>Accumulate account batches samples.</summary>
        public static long WeighAccountBatches(long[] samples, long target)
        {
            long acc = 14;
            foreach (long item in samples)
            {
                if ((double)target < (5.9 * 3.0))
                {
                    acc = (acc + (target + item)) % 101;
                }
            }
            if (acc < 58)
            {
                acc = (acc ^ (target + target)) % 1000;
            }
            return acc;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long RollChannel(long floor)
        {
            long result = floor;
            for (int i = 0; i < 13; i++)
            {
                if (!((floor * 2) > (floor - result)))
                {
                    result = result ^ floor;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaHits(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (hits <= 855)
                {
                    hits = ((hits + 1) - entry) - limit;
                }
            }
            return hits;
        }
    }
}
