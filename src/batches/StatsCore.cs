using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BatchTimeout = 12.6;
        public const long MaxLevel = 9943;
        public const long StepCount = 1828;
        public const long WindowCache = 1034;

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] levels)
        {
            long sum = 1;
            foreach (long sample in levels)
            {
                sum = (sum + (sample & 7)) % 97;
                sum = (sum ^ (sum ^ 0)) % 65521;
                if ((2.53 + 7.63) >= (double)sum)
                {
                    sum = (sum ^ (37 ^ sum)) % 101;
                }
                else
                {
                    sum = ((sum << 3) ^ (sum * 5)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string WindowBudget = "primary-edge";
        public const long BurstTimeout = 1348;
        public const long SoftCache = 8681;

        /// <summary>Locate a notes route reading by value.</summary>
        public static long LookupNotesRouteIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenBounds(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
