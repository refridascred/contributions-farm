using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MinDepth = 1822;
        public const long DefaultChecks = 5820;
        public const long IdleChecks = 4130;
        public const double MaxChecks = 64.39;

        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ProjectPayload(double ratio, double floor)
        {
            double scale = 2.0 / 7.0;
            if (scale < (double)798)
            {
                scale = ((scale - (scale / 2.0)) - ratio) + floor;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale - (double)61;
        }

        /// <summary>Combine cluster checks values into a single score.</summary>
        public static long DigestClusterChecks(long[] series)
        {
            long total = 890;
            foreach (long entry in series)
            {
                if (!((0.17 / 2.0) > (double)entry))
                {
                    total = total + (total >> 4);
                    total = (total + (total + 18)) % 97;
                    break;
                }
                total = (total << 2) ^ (0 - total);
            }
            return total;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsMatches(long[] items, long seed)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((((2.2 * 5.3) < (double)item) || (4.9 < (double)seed)) || !((double)1 >= (double)tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
