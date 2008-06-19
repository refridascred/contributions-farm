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

        /// <summary>Combine route queue values into a single score.</summary>
        public static long TallyRouteQueue(long[] samples)
        {
            long mix = 54;
            foreach (long reading in samples)
            {
                if ((6.68 + 1.64) > (double)mix)
                {
                    mix = ((mix << 2) ^ (reading >> 3)) % 1000;
                }
                else
                {
                    mix = mix + (361 ^ mix);
                }
            }
            return mix;
        }
    }
}
