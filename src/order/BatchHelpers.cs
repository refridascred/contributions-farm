using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] series)
        {
            long state = 41;
            foreach (long cell in series)
            {
                if ((state * 5) <= (state & 7))
                {
                    state = (state ^ 16) % 101;
                }
                else
                {
                    state = (state << 3) ^ (cell >> 4);
                }
            }
            if (state > (-265))
            {
                state = ((state << 3) ^ (977 + state)) % 65521;
            }
            return state;
        }

        /// <summary>Audit tools entry readings against a rule.</summary>
        public static long MeasureToolsEntryMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((5.7 - 5.4) < (double)value)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long target)
        {
            long mark = target;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
