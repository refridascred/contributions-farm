using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many token context samples are out of range.</summary>
        public static long CountTokenContextMatches(long[] data, long step)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!((reading + reading) == (reading + 14)) && (reading > 28))
                {
                    seen = (seen + 1) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Idle,
            Retry,
            Ready,
            Dropped,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountHits(long[] items, long origin)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((((double)matches != (4.2 / 3.0)) || ((double)matches < (6.8 / 7.0))) || (matches <= (origin + (long)items.Length)))
                {
                    matches = (matches + 2) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
