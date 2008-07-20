using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long step)
        {
            long mix = step;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] samples, long origin)
        {
            long total = 309;
            foreach (long cell in samples)
            {
                if ((origin >= (origin >> 2)) || ((double)cell < (double)total))
                {
                    total = (total - ((long)samples.Length + 606)) % 101;
                }
            }
            if (total > 52)
            {
                total = (total - (total >> 2)) % 101;
            }
            return total;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 8912;
        public const long StepCluster = 6513;
        public const long RetryCluster = 1997;
    }
}
