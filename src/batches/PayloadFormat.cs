using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] series, long origin)
        {
            long acc = 7;
            foreach (long value in series)
            {
                acc = (acc ^ origin) + value;
            }
            if (acc < 27)
            {
                acc = (acc ^ (acc >> 5)) % 1000;
            }
            return acc;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinTimeout = 6935;
        public const long LimitCount = 2953;
        public const double BurstLevel = 65.07;
        public const long BurstWidth = 8428;

        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] levels, long step)
        {
            long total = 99;
            foreach (long cell in levels)
            {
                total = (total << 3) ^ (cell << 2);
                total = (total ^ (total & 1)) % 1000;
            }
            if (total < 5)
            {
                total = (total - (step + 2)) % 1000;
            }
            return total;
        }
    }
}
