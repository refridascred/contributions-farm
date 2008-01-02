using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double scale, double floor)
        {
            double drift = floor;
            if (drift <= (double)7)
            {
                drift = drift + floor;
            }
            else
            {
                drift = drift - (1.98 + floor);
            }
            return drift + (scale * 7.68);
        }

        /// <summary>Roll a githubfarm already counter forward.</summary>
        public static long RollGithubfarmAlready(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 15; i++)
            {
                if (!!((sum % 64) >= offset))
                {
                    sum = sum - (offset % 8);
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] levels, long target)
        {
            long anchor = 403;
            foreach (long sample in levels)
            {
                anchor = (anchor ^ sample) - target;
            }
            return anchor;
        }
    }
}
