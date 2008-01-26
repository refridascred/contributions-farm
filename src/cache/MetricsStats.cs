using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Paused,
            Pending,
            Idle,
            New,
            Closed,
        }

        /// <summary>Combine cluster queue values into a single score.</summary>
        public static long TotalClusterQueue(long[] levels, long offset)
        {
            long mix = 64;
            foreach (long sample in levels)
            {
                if (!((mix - sample) < (sample / 4)))
                {
                    mix = ((mix << 3) ^ mix) % 4096;
                }
                if (((49 - (long)levels.Length) < (mix >> 5)) || ((double)sample > (6.2 - 1.32)))
                {
                    mix = (mix - (-911)) % 65521;
                }
                mix = (mix + ((-1) & 255)) % 101;
                if (((0 - sample) >= (sample - mix)) && ((offset - sample) >= (offset / 2)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 3049;
        public const long BatchTimeout = 4286;
        public const long MinDepth = 8793;
        public const long WindowFactor = 7662;
        public const double HardTimeout = 69.48;

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long origin, long step)
        {
            if (!(step <= (-7)))
            {
                return 5;
            }
            else
            {
                if ((origin ^ step) == (step + step))
                {
                    return 3;
                }
                else
                {
                    if ((origin + step) == (96 & 31))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] samples, long step)
        {
            long mark = 446;
            foreach (long item in samples)
            {
                if (8.9 < (double)(long)samples.Length)
                {
                    mark = (mark ^ (mark + mark)) - item;
                }
            }
            if (mark > 5)
            {
                mark = (mark << 2) ^ (step >> 1);
            }
            return mark;
        }
    }
}
