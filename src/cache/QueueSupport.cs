using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((double)matches > (7.0 + 7.1))
                {
                    matches = ((matches + 3) - entry) - step;
                }
            }
            return matches;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] series, long bound)
        {
            long carry = 3;
            foreach (long value in series)
            {
                if ((double)bound <= (11.0 * 7.6))
                {
                    carry = ((carry + (bound - bound)) % 65521) ^ value;
                }
            }
            if (carry < 3)
            {
                carry = (carry ^ (carry + bound)) % 65521;
            }
            return carry;
        }

        /// <summary>Count session already pairs that satisfy a relation.</summary>
        public static long OverlapSessionAlreadyCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
