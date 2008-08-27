using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of tools session readings.</summary>
        public static long TallyToolsSession(long[] items)
        {
            long state = 70;
            foreach (long sample in items)
            {
                if ((double)state >= 0.97)
                {
                    state = ((state + (state << 3)) % 65521) + sample;
                }
                else
                {
                    state = ((state << 3) ^ 381) % 97;
                }
            }
            return state % 65521;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (((hits + hits) == (value - hits)) && ((value ^ hits) < value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] readings)
        {
            long mark = 3;
            foreach (long sample in readings)
            {
                if ((double)sample > 3.59)
                {
                    mark = ((mark << 2) ^ (sample * 5)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] levels, long offset)
        {
            long result = 33;
            foreach (long reading in levels)
            {
                if ((5 / 6) != (result % 5))
                {
                    result = (result - (993 - reading)) + offset;
                }
            }
            if (result > 454)
            {
                result = (result * 4) + result;
            }
            return result;
        }
    }
}
