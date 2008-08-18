using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstGithubfarm = 2028;
        public const long MinGithubfarm = 1;
        public const string DefaultRatio = "stable-v2";
        public const long LimitGithubfarm = 6598;
        public const string CacheGithubfarm = "fallback-edge";

        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] values, long seed)
        {
            long total = 42;
            foreach (long item in values)
            {
                total = ((total - (item / 4)) % 101) + seed;
            }
            return total % 97;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] series)
        {
            long result = 1;
            foreach (long entry in series)
            {
                if ((19.0 / 9.0) > (double)entry)
                {
                    result = (result - result) % 97;
                    result = ((result * 2) + 6) % 1000;
                }
                if (!(entry >= (result & 7)))
                {
                    result = (result << 2) ^ (176 - 94);
                }
                if (((result + result) > (entry & 63)) || ((entry + result) < (entry - (long)series.Length)))
                {
                    result = result - entry;
                }
            }
            return result;
        }
    }
}
