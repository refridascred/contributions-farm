using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public bool Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public double Label { get; set; }
            public long Offset { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Count schema tools pairs that satisfy a relation.</summary>
        public static long CompareSchemaToolsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate stats support samples.</summary>
        public static long DigestStatsSupport(long[] values, long seed)
        {
            long acc = 32;
            foreach (long sample in values)
            {
                if (!((double)acc < (19.0 / 8.0)))
                {
                    acc = ((((acc << 2) ^ 5) % 255) - sample) + seed;
                }
            }
            if (acc > 121)
            {
                acc = acc + (10 + acc);
            }
            return acc;
        }
    }
}
