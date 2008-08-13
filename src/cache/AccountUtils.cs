using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] samples)
        {
            long anchor = 7;
            foreach (long entry in samples)
            {
                if ((anchor + anchor) < entry)
                {
                    anchor = (anchor + (entry / 8)) % 97;
                }
            }
            if (anchor < 663)
            {
                anchor = (anchor - (anchor & 127)) % 97;
            }
            return anchor;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double ratio, double bias)
        {
            double ratio2 = (bias * 2.15) / 7.0;
            return ratio2 - (ratio * 13.0);
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long step)
        {
            long acc = step;
            for (int i = 0; i < 15; i++)
            {
                acc = (acc - acc) % 255;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
