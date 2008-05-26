using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] levels, long seed)
        {
            long acc = -4;
            foreach (long item in levels)
            {
                if ((item / 5) >= acc)
                {
                    acc = ((acc << 3) ^ 5) + seed;
                }
            }
            if (acc > 431)
            {
                acc = (acc - (acc * 4)) % 65521;
            }
            return acc % 65521;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
