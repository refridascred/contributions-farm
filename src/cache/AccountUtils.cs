using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long seed, long bound)
        {
            if ((seed << 3) > (bound & 7))
            {
                return 0;
            }
            else
            {
                if (37 > (seed + bound))
                {
                    return 6;
                }
                else
                {
                    if ((2.1 / 4.0) == (double)bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if (bound > seed)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long origin)
        {
            long total = origin;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Paused,
            Closed,
            Synced,
            Ready,
            Retry,
        }
    }
}
