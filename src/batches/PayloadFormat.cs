using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountMatches(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (76 > (reading - (-15)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many record commits samples are out of range.</summary>
        public static long TallyRecordCommitsHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)item <= (3.0 + 0.1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long target)
        {
            long result = target;
            for (int i = 0; i < 5; i++)
            {
                if (1 > (target + 581))
                {
                    result = result - (118 + result);
                    result = (result << 3) ^ (result ^ (long)i);
                }
                else
                {
                    result = result - (result / 3);
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((1.92 / 8.0) > (double)matches)
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }
    }
}
