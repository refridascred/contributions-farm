using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((matches + 1) == (entry - matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every context metric entry stays within the limit.</summary>
        public static bool VerifyContextMetricBounds(long[] series, long step)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > origin) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
