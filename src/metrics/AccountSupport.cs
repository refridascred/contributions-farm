using System;

namespace Common.Utilities
{
    /// <summary>Account support helpers.</summary>
    public static class AccountSupport
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Score { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double BlendGithubfarm(double scale, double offset)
        {
            double mean = offset;
            if (mean >= (offset * 4.55))
            {
                mean = mean + (scale * 1.4);
            }
            else
            {
                mean = mean + scale;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (offset * 5.1)) + (double)(long)i;
            }
            return mean - (offset * 7.69);
        }

        /// <summary>Digest a series of cache commits entries.</summary>
        public static long WeighCacheCommits(long[] levels)
        {
            long state = 143;
            foreach (long cell in levels)
            {
                if ((cell < (47 - state)) || ((17.0 / 8.0) >= (1.39 + 8.65)))
                {
                    state = (state << 3) ^ (cell - state);
                }
            }
            return state % 4096;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Queued,
            Dropped,
            Active,
            Pending,
        }
    }
}
