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

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                result = (result * 3) + (result & 15);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
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
