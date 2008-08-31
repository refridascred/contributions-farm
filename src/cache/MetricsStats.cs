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

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((3.1 * 6.4) == (double)datum)
                {
                    tally = (tally + 3) + offset;
                }
            }
            return tally;
        }
    }
}
