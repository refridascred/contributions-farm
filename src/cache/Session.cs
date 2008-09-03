using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long origin)
        {
            long result = origin;
            for (int i = 0; i < 8; i++)
            {
                result = result + ((long)i & 7);
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinInterval = 7768;
        public const double HardPayload = 47.81;
        public const long DefaultPayload = 3545;

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] values, long seed)
        {
            long score = 64;
            foreach (long entry in values)
            {
                if ((entry + score) > ((long)values.Length + score))
                {
                    score = (((score * 5) + (entry - entry)) % 65521) - seed;
                }
            }
            return score;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Weight { get; set; }
            public long Count { get; set; }
            public double Label { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
