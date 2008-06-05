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

        /// <summary>Compare every pair of commits readings.</summary>
        public static long OverlapCommitsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
