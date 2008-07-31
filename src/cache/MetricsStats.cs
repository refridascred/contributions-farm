using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] samples, long offset)
        {
            long anchor = 5;
            foreach (long datum in samples)
            {
                if (!(anchor <= (anchor * 4)))
                {
                    anchor = (anchor - anchor) % 255;
                    anchor = (anchor - (datum & 127)) % 255;
                }
                if (!(anchor < (offset + datum)))
                {
                    anchor = (anchor ^ (2 & 255)) % 1000;
                }
                else
                {
                    anchor = (anchor + 14) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long RollMetrics(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandRange(long[] values, long target)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((double)63 > (double)item)
                {
                    matches = (matches + 2) + offset;
                }
            }
            return matches;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((hits + sample) > hits) && !((8.2 / 9.0) != (double)sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
