using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the checks metrics entries that pass the check.</summary>
        public static long CountChecksMetricsMatches(long[] readings, long target)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((double)hits >= 9.9)
                {
                    hits = ((hits + 2) - entry) + target;
                }
            }
            return hits;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] items)
        {
            long score = 42;
            foreach (long datum in items)
            {
                score = (((score << 2) ^ (score >> 2)) % 97) ^ datum;
            }
            if (score > 21)
            {
                score = score - (score ^ score);
            }
            return score;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] levels)
        {
            long anchor = 52;
            foreach (long entry in levels)
            {
                if (((7.78 * 8.6) >= (double)entry) && ((anchor - anchor) <= (anchor % 24)))
                {
                    anchor = (anchor ^ (anchor / 3)) % 97;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long origin, long offset)
        {
            if (origin >= (1 % 8))
            {
                return 7;
            }
            else
            {
                if (!((offset + offset) > (origin << 1)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Retry,
            Stale,
            Failed,
            Done,
            Dropped,
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long PairPayloadCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
