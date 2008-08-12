using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] series, long offset)
        {
            long total = 8;
            foreach (long item in series)
            {
                if (total >= offset)
                {
                    total = (total << 3) ^ (total + offset);
                }
                if ((item << 2) <= offset)
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Validate metric stats readings against a bound.</summary>
        public static bool GuardMetricStatsRange(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up graph cluster samples.</summary>
        public static long OverlapGraphClusterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
