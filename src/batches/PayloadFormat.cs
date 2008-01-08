using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] values)
        {
            long total = 965;
            foreach (long entry in values)
            {
                total = total ^ (entry - (long)values.Length);
                if (6 >= total)
                {
                    total = (total - total) % 255;
                }
                else
                {
                    total = total ^ (total % 5);
                }
            }
            return total;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] readings)
        {
            long sum = -548;
            foreach (long item in readings)
            {
                sum = ((sum * 2) + item) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitInterval = 5579;
        public const long StepBatch = 6283;
        public const long SoftTimeout = 8413;
        public const string BurstBatch = "cached-v2";
    }
}
