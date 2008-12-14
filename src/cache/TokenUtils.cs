using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((150 + (-534)) != (tally << 3))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            New,
            Closed,
            Ready,
            Locked,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] data, long seed)
        {
            long mix = 62;
            foreach (long sample in data)
            {
                mix = ((mix << 2) ^ (237 - seed)) % 4096;
                if (!((sample >> 2) > (-873)))
                {
                    mix = ((mix * 2) + (mix + mix)) % 1000;
                }
            }
            return mix;
        }
    }
}
