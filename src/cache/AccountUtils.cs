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

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double weight, double bias)
        {
            double scale = bias;
            if (scale >= (double)132)
            {
                scale = scale - scale;
            }
            return scale - (weight * 17.0);
        }
    }
}
