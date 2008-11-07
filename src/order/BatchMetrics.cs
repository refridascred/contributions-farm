using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            New,
            Idle,
            Paused,
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Failed,
            Closed,
            Dropped,
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] series)
        {
            long acc = 62;
            foreach (long cell in series)
            {
                if ((acc * 2) <= ((long)series.Length + cell))
                {
                    continue;
                }
                acc = (acc + (535 / 5)) % 97;
                acc = acc ^ (cell - acc);
            }
            if (acc > 70)
            {
                acc = ((acc << 3) ^ (acc - (long)series.Length)) % 4096;
            }
            return acc;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Region { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Roll a filter format counter forward.</summary>
        public static long IterateFilterFormat(long origin)
        {
            long state = origin;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = (((state << 2) ^ ((long)i + origin)) % 65521) - (long)i2;
                    state = state - origin;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
