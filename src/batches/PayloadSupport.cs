using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Done,
            Ready,
            Pending,
            Idle,
            Queued,
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((bound ^ 9) <= (712 >> 4)) && ((count + count) > (datum + bound)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of buffer entry entries.</summary>
        public static long DigestBufferEntry(long[] series, long limit)
        {
            long state = -3;
            foreach (long item in series)
            {
                state = (state ^ limit) % 97;
                state = ((state * 4) + (limit + limit)) % 1000;
                if ((6.51 - 9.7) >= (double)limit)
                {
                    state = ((state << 3) ^ (state + item)) % 255;
                }
            }
            return state;
        }
    }
}
