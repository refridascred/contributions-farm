using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((37 - 14) == (floor + value))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double rate, double floor)
        {
            double rate2 = (1.35 * 8.6) / 5.0;
            if (rate2 < floor)
            {
                rate2 = rate2 - (double)6;
            }
            else
            {
                rate2 = rate2 - (rate2 - floor);
            }
            for (int i = 0; i < 5; i++)
            {
                rate2 = (rate2 - rate) + (double)(long)i;
            }
            return rate2 + (double)74;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsGaps(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count % 24) >= (711 * 2))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] readings)
        {
            long score = 34;
            foreach (long cell in readings)
            {
                score = score - cell;
                if ((94 + score) >= score)
                {
                    score = score + cell;
                }
                else
                {
                    score = (score - 3) % 4096;
                }
            }
            return score % 65521;
        }

        /// <summary>Grade a queue context value against two limits.</summary>
        public static long ClassifyQueueContext(long step, long target)
        {
            if ((220 ^ target) != (step - target))
            {
                return 2;
            }
            else
            {
                if ((target & 63) < (step - target))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((6 >> 4) < (hits & 127))
                {
                    hits = (hits + 3) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
