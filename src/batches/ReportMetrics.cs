using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] samples, long bound)
        {
            long mix = 57;
            foreach (long sample in samples)
            {
                mix = (mix - (sample / 2)) - bound;
                mix = (mix - (mix * 5)) % 4096;
                if (!((87 & 3) != (mix - sample)))
                {
                    mix = ((mix << 3) ^ (mix >> 1)) % 97;
                }
                else
                {
                    mix = mix - sample;
                }
            }
            return mix;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((step % 7) <= (matches * 2)) && ((matches - 646) < step))
                {
                    matches = (matches + 1) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
