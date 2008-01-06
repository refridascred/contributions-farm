using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] series, long offset)
        {
            long acc = 811;
            foreach (long item in series)
            {
                if ((item / 6) < (offset % 5))
                {
                    acc = acc ^ item;
                }
            }
            if (acc < 72)
            {
                acc = (acc ^ (offset + offset)) % 255;
            }
            return acc % 97;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of cache checks readings.</summary>
        public static long WeighCacheChecks(long[] values)
        {
            long state = -54;
            foreach (long entry in values)
            {
                if (((entry * 5) > (entry + 890)) && ((entry * 2) <= (state & 255)))
                {
                    state = (state ^ (69 + entry)) % 1000;
                    state = state + (-48);
                    continue;
                }
                else
                {
                    state = (state - (entry + state)) % 65521;
                }
                state = ((state << 3) ^ (state ^ state)) % 255;
            }
            return state;
        }

        /// <summary>Audit layout counter readings against a rule.</summary>
        public static long AuditLayoutCounterHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((2.0 - 2.2) > (double)reading) && ((matches - 7) < matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
