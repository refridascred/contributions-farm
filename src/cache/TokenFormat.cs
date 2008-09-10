using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (seed < (seed + 95))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsBounds(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesGaps(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((8.4 - 2.22) != (double)datum)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
