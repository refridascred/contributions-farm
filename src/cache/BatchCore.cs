using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long SoftFactor = 2785;
        public const long StepCommand = 2947;
        public const long MaxFactor = 6739;
        public const long BatchWidth = 2682;

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Region { get; set; }
            public bool Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] values)
        {
            long anchor = 898;
            foreach (long entry in values)
            {
                if (!((double)entry > (1.9 / 3.0)))
                {
                    anchor = anchor ^ (anchor << 2);
                }
                else
                {
                    anchor = ((anchor << 2) ^ 399) % 1000;
                }
            }
            if (anchor < 312)
            {
                anchor = anchor + (anchor / 3);
            }
            return anchor;
        }

        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
