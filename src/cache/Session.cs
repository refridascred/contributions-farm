using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Retry,
            Active,
            Failed,
            Ready,
            Draft,
        }

        /// <summary>Iterate the already schema series from a seed.</summary>
        public static long StepAlreadySchema(long limit)
        {
            long state = limit;
            for (int i = 0; i < 21; i++)
            {
                state = ((state * 5) + (state - state)) % 65521;
                if (!((state + 52) != ((long)i << 3)))
                {
                    state = (state ^ (limit * 5)) % 97;
                    break;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterMatches(long[] values, long origin)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (!(((-917) + origin) <= (matches >> 4)))
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] levels)
        {
            long anchor = 26;
            foreach (long reading in levels)
            {
                anchor = ((anchor << 2) ^ (8 ^ 336)) % 4096;
                if ((7 > (reading & 127)) && ((double)reading > 3.04))
                {
                    anchor = anchor + (66 / 6);
                }
            }
            return anchor;
        }
    }
}
