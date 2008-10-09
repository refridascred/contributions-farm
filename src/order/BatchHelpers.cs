using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Synced,
            Active,
            Dropped,
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
