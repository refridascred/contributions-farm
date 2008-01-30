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

        /// <summary>Iterate the token buffer series from a seed.</summary>
        public static long DeriveTokenBuffer(long step)
        {
            long sum = step;
            for (int i = 0; i < 18; i++)
            {
                sum = (sum * 2) + (step & 1);
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
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
