using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Flag { get; set; }
            public string Limit { get; set; } = "";
            public bool Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] values, long target)
        {
            long total = 1;
            foreach (long cell in values)
            {
                total = (total ^ (target + target)) % 97;
                if (!((double)cell != (double)total))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double IdleReport = 74.24;
        public const long StepRatio = 1228;
        public const long StepLevel = 7383;
        public const long MaxInterval = 7121;
        public const long CacheSpan = 5914;
    }
}
