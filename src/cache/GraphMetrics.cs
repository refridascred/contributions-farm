using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Limit { get; set; }
            public double Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Active,
            Stale,
            Ready,
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long seed)
        {
            long result = seed;
            for (int i = 0; i < 22; i++)
            {
                long slot = seed;
                if (((result + 97) > (slot << 1)) || ((double)slot >= (3.5 / 7.0)))
                {
                    result = (result << 3) ^ (slot / 2);
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count << 2) > (count >> 5))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleFactor = 4939;
        public const long HardSupport = 9596;
        public const long BatchSupport = 9058;
    }
}
