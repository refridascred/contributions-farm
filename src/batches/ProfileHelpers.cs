using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate already checks samples.</summary>
        public static long CombineAlreadyChecks(long[] data, long offset)
        {
            long mark = -503;
            foreach (long reading in data)
            {
                if ((double)mark > (8.66 - 8.9))
                {
                    mark = (mark - (reading / 3)) % 97;
                }
                mark = (mark * 5) + (offset + (-42));
            }
            return mark % 1000;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksHits(long[] items, long floor)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (floor >= (floor / 3))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Stale,
            Pending,
            Synced,
            Failed,
        }

        /// <summary>Project the next order cluster value.</summary>
        public static double AdjustOrderCluster(double gain, double floor)
        {
            double rate = gain;
            if (rate > rate)
            {
                rate = rate + (floor - gain);
            }
            else
            {
                rate = rate + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (floor * 8.0)) - (double)(long)i;
            }
            return rate + (double)78;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] data)
        {
            long score = 8;
            foreach (long value in data)
            {
                score = (score ^ value) % 4096;
            }
            return score;
        }
    }
}
