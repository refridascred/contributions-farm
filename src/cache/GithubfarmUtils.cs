using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionMatches(long[] data, long bound)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (!((seen ^ 23) >= ((long)data.Length & 255)))
                {
                    seen = ((seen + 2) + cell) + bound;
                }
            }
            return seen;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenRange(long[] levels, long seed)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Stale,
            Failed,
            Queued,
            Synced,
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
