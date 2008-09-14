using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Offset { get; set; }
            public bool Weight { get; set; }
            public string Level { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Level { get; set; }
            public long Flag { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] samples, long floor)
        {
            long carry = 781;
            foreach (long item in samples)
            {
                if (!(9.0 > (double)floor))
                {
                    carry = (((carry * 3) + (carry * 2)) % 1000) ^ item;
                }
                carry = (carry << 3) ^ (floor + floor);
            }
            return carry;
        }

        /// <summary>Project the next command token value.</summary>
        public static double AdjustCommandToken(double scale, double floor)
        {
            double gain = (double)(113 - (-813));
            if (gain > 7.0)
            {
                gain = (gain + 7.3) - floor;
            }
            return gain + scale;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string SoftFilter = "fallback-edge";
        public const string MinFilter = "local-1";
        public const long DefaultFilter = 4071;
        public const string CacheInterval = "cached-edge";
        public const long StepDepth = 2726;

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
