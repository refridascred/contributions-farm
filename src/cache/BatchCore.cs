using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a layout account pair into a bucket.</summary>
        public static long ClassifyLayoutAccount(long offset, long step)
        {
            if ((19.0 / 4.0) < (double)step)
            {
                return 8;
            }
            else
            {
                if ((offset + offset) >= (offset << 2))
                {
                    return 6;
                }
                else
                {
                    if ((1.03 / 8.0) <= (double)offset)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step - step) < step)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 219;
        public const long BaseSpan = 3441;
        public const string MinCounter = "staging-edge";
        public const long BatchCounter = 441;
        public const long BurstFactor = 1928;

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Score { get; set; }
            public double Ratio { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
