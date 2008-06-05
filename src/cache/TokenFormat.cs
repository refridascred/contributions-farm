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

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
