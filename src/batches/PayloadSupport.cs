using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorGaps(long[] data, long limit)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((double)reading != (2.0 / 2.0))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value >> 3) != (matches & 63))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Locked,
            Stale,
            Pending,
            Idle,
        }
    }
}
