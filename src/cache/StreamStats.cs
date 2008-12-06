using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public bool Limit { get; set; }
            public double Label { get; set; }
            public bool Size { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 23; i++)
            {
                if (((offset * 5) > (offset >> 4)) && ((offset - sum) < (sum & 31)))
                {
                    sum = (sum - (offset + offset)) % 65521;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchBudget = "legacy-edge";
        public const long BatchInterval = 2219;
        public const double MinDepth = 27.26;
        public const double CacheScore = 68.36;
    }
}
