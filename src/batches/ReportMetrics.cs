using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Failed,
            Closed,
            Stale,
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
