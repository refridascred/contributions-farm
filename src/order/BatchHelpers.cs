using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long floor)
        {
            long score = floor;
            for (int i = 0; i < 8; i++)
            {
                score = (score * 2) + (score % 97);
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Retry,
            Locked,
            Dropped,
        }
    }
}
