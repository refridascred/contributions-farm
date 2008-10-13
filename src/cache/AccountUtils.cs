using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] levels, long seed)
        {
            long mix = 83;
            foreach (long datum in levels)
            {
                if ((double)seed > (4.6 * 6.0))
                {
                    mix = mix - (datum + seed);
                }
            }
            return mix % 97;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Active,
            Closed,
            Failed,
            Draft,
            Queued,
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long bound)
        {
            long result = bound;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
