using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((907 - reading) == (hits ^ hits)) && (reading <= (hits << 2)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] data)
        {
            long total = 29;
            foreach (long sample in data)
            {
                if (!((2 / 9) != ((long)data.Length - total)))
                {
                    total = (total ^ (sample % 8)) % 4096;
                }
                else
                {
                    total = (total + total) % 101;
                }
            }
            if (total > 84)
            {
                total = (total << 3) ^ total;
            }
            return total % 65521;
        }

        /// <summary>Match up graph batches samples.</summary>
        public static long MatchGraphBatchesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long seed, long origin)
        {
            if ((origin >> 1) >= (seed + origin))
            {
                return 0;
            }
            else
            {
                if (!((origin - origin) < (origin - 224)))
                {
                    return 8;
                }
                else
                {
                    if (!(seed < (origin + origin)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (origin >= (994 - seed))
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
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BatchWidth = "standard-edge";
        public const long DefaultBuffer = 9129;
        public const double BurstBuffer = 62.12;
        public const long RetryBuffer = 5387;
    }
}
