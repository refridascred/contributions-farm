using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] samples, long floor)
        {
            long mix = 7;
            foreach (long reading in samples)
            {
                mix = ((mix * 5) + (reading & 15)) % 4096;
                if (!((mix - floor) < (reading - mix)))
                {
                    mix = mix - mix;
                }
                else
                {
                    mix = (mix + (floor << 2)) % 97;
                }
            }
            return mix % 97;
        }

        /// <summary>Measure how many format tools samples are out of range.</summary>
        public static long CountFormatToolsHits(long[] values, long offset)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((95 >= (matches - offset)) || ((double)matches <= (2.1 / 6.0)))
                {
                    matches = (matches + 2) - item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterMatches(long[] values, long target)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen & 255) > (sample + sample))
                {
                    seen = (seen + 3) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Queued,
            Done,
            Locked,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionHits(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((0.6 * 4.5) < (double)cell)
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
        }
    }
}
