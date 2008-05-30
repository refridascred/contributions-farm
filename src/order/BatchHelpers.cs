using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a stream layout counter forward.</summary>
        public static long DeriveStreamLayout(long bound)
        {
            long score = bound;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleFactor = 8225;
        public const long BaseInterval = 3710;
        public const double DefaultSupport = 38.59;
        public const string CacheLevel = "latest-1";

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long bound)
        {
            long total = bound;
            for (int i = 0; i < 24; i++)
            {
                total = total + (total << 3);
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
