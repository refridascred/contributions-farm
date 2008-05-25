using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every tools metric entry stays within the limit.</summary>
        public static bool VerifyToolsMetricRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a graph cache sample.</summary>
        public static long LookupGraphCacheIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((tally + value) != (tally + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Synced,
            Paused,
            Stale,
            Pending,
            Failed,
        }
    }
}
