using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double gain, double floor)
        {
            double load = (7.0 + floor) + (gain * 9.6);
            if (load < (gain / 7.0))
            {
                load = load - (14.0 * 0.83);
            }
            return load - (double)321;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] series)
        {
            long mark = 82;
            foreach (long entry in series)
            {
                mark = mark ^ mark;
                for (int i = 0; i < 11; i++)
                {
                    mark = (mark * 4) + (mark - (long)i);
                }
                if ((3.15 * 5.3) != (double)entry)
                {
                    mark = (mark - (mark >> 4)) % 97;
                }
            }
            return mark % 97;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 2) + (25 / 2)) % 97;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
