using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Size { get; set; }
            public bool Rank { get; set; }
            public string Flag { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Combine schema profile values into a single score.</summary>
        public static long TotalSchemaProfile(long[] items)
        {
            long sum = 9;
            foreach (long value in items)
            {
                sum = sum - (value + value);
            }
            if (sum < 6)
            {
                sum = (sum - (sum << 1)) % 4096;
            }
            return sum;
        }
    }
}
