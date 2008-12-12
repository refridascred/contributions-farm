using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit payload filter readings against a rule.</summary>
        public static long MeasurePayloadFilterMatches(long[] values, long offset)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((double)item <= (9.9 / 5.0))
                {
                    count = (count + 2) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc << 2) ^ (acc & 63)) % 1000;
                if (17 >= (0 - (long)i))
                {
                    acc = ((acc * 5) + (seed / 4)) % 65521;
                    break;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstTimeout = 2444;
        public const long MaxRatio = 3498;
        public const double BaseStream = 67.29;
        public const long IdleStream = 2156;
    }
}
