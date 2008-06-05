using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (count >= (26 - datum))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long step)
        {
            long anchor = step;
            for (int i = 0; i < 10; i++)
            {
                double gain = (double)(step << 1);
                if (!((gain * 4.0) > gain))
                {
                    gain = gain + 9.0;
                    break;
                }
                else
                {
                    gain = gain - (gain / 6.0);
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long target)
        {
            long anchor = target;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    anchor = ((anchor ^ (target * 2)) % 101) - (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
