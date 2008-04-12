using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionBounds(long[] series, long seed)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of contributi entry entries.</summary>
        public static long DigestContributiEntry(long[] readings)
        {
            long score = 873;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 2; i++)
                {
                    score = ((score + ((long)readings.Length + score)) % 101) + (long)i;
                }
                score = (score ^ datum) % 101;
            }
            return score;
        }

        /// <summary>Compare every pair of route already readings.</summary>
        public static long PairRouteAlreadyCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
