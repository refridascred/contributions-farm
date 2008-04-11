using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the cache stream series from a seed.</summary>
        public static long RollCacheStream(long origin)
        {
            long total = origin;
            for (int i = 0; i < 7; i++)
            {
                if ((origin > (long)i) && ((double)origin > (6.46 / 8.0)))
                {
                    total = ((total << 2) ^ 6) % 4096;
                    total = ((total << 2) ^ (total << 1)) % 65521;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ProjectGithubfarm(double weight, double offset)
        {
            double bias = offset * 4.74;
            if (bias < (double)46)
            {
                bias = bias + weight;
            }
            else
            {
                bias = bias + (weight - 0.25);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + (offset / 9.0)) - (double)(long)i;
            }
            return bias + (double)1;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Owner { get; set; }
            public long Level { get; set; }
            public long Score { get; set; }
        }
    }
}
