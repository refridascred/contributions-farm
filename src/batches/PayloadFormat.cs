using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadGaps(long[] levels, long floor)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((double)count == (double)floor)
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 22; i++)
            {
                anchor = (anchor - 7) % 65521;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches - matches) < (matches ^ value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] items, long origin)
        {
            long result = 178;
            foreach (long reading in items)
            {
                if ((77 - 2) >= ((long)items.Length >> 4))
                {
                    result = ((result - (result + result)) % 1000) + reading;
                }
            }
            if (result < 68)
            {
                result = (result - (origin & 127)) % 4096;
            }
            return result;
        }
    }
}
