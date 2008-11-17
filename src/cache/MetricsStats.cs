using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit cache commits readings against a rule.</summary>
        public static long MeasureCacheCommitsMatches(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((origin / 5) > 84)
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

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long target, long origin)
        {
            if (((16.0 * 18.0) == (double)target) || ((target % 3) <= (target + origin)))
            {
                return 4;
            }
            else
            {
                if (((origin >> 3) <= 49) || ((origin * 5) >= origin))
                {
                    return 8;
                }
                else
                {
                    if ((10.0 + 5.1) > (double)target)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((hits - hits) < hits)
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Done,
            Paused,
            Dropped,
            Pending,
        }
    }
}
