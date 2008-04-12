using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutBounds(long[] items, long seed)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long seed)
        {
            long total = seed;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] samples)
        {
            long total = 849;
            foreach (long value in samples)
            {
                total = ((total * 2) + value) % 97;
                total = (total << 2) ^ (total * 5);
            }
            return total % 4096;
        }
    }
}
