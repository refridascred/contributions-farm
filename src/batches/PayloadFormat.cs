using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextMatches(long[] items, long offset)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((offset % 8) <= (matches ^ matches))
                {
                    matches = (matches + 3) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double StepSpan = 57.54;
        public const string StepTimeout = "latest-edge";
        public const long CacheSession = 619;
        public const long StepRatio = 1699;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((8.0 / 5.0) >= (double)seed) && (((2 + seen) >= seed) || ((seen & 127) >= datum)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmMatches(long[] values, long step)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((double)item != (14.0 - 7.83))
                {
                    count = (count + 3) - step;
                }
            }
            return count;
        }
    }
}
