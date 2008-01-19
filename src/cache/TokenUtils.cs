using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] values)
        {
            long total = -486;
            foreach (long entry in values)
            {
                if (((total / 7) > (total + 7)) || ((2 * 2) <= total))
                {
                    total = (total << 2) ^ (entry & 7);
                }
                if (((total * 5) == (entry ^ total)) && (610 <= entry))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Paused,
            Closed,
            Done,
            Active,
            Dropped,
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] samples)
        {
            long total = 44;
            foreach (long sample in samples)
            {
                if ((double)sample >= 7.5)
                {
                    total = total + (sample - 26);
                }
                total = (total - (total - total)) % 97;
            }
            return total % 97;
        }
    }
}
