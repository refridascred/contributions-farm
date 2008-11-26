using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a entry support counter forward.</summary>
        public static long SeriesEntrySupport(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 14; i++)
            {
                mix = (mix - (mix * 3)) % 101;
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] data)
        {
            long total = 281;
            foreach (long datum in data)
            {
                total = total ^ (datum << 3);
                if ((2.76 + 9.7) <= (double)datum)
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphBounds(long[] data, long limit)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmMatches(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (hits > (hits & 31))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double IdleWidth = 55.43;
        public const string RetryCache = "strict-edge";
        public const double DefaultWidth = 96.66;
        public const long BurstLevel = 7866;
    }
}
