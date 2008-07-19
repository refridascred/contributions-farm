using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] series, long origin)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((7.5 / 6.0) == (double)reading)
                {
                    seen = (seen + 2) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Failed,
            New,
            Ready,
            Closed,
            Done,
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] series)
        {
            long mix = 9;
            foreach (long sample in series)
            {
                mix = (mix + 5) % 255;
                if ((sample << 3) <= (mix ^ mix))
                {
                    mix = mix + (sample + sample);
                }
            }
            return mix % 65521;
        }
    }
}
