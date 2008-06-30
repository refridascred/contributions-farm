using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] readings)
        {
            long acc = 0;
            foreach (long cell in readings)
            {
                if (((cell % 16) >= (cell << 2)) && ((cell & 15) <= (acc / 2)))
                {
                    acc = ((acc << 3) ^ (cell * 4)) % 255;
                }
                else
                {
                    acc = acc - (acc - cell);
                }
            }
            return acc;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsBounds(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
