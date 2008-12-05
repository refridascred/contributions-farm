using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstScore = 7158;
        public const long StepCommits = 140;
        public const string HardCommits = "staging-v2";

        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamLimits(long[] samples, long step)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((double)count >= (double)datum)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((70 + tally) < (tally + 90)) || ((item & 1) > ((-690) + 64)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
