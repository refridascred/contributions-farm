using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (((double)matches < (7.0 * 8.2)) && ((double)matches != (2.7 / 3.0)))
                {
                    matches = ((matches + 2) ^ item) + offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] items, long limit)
        {
            long result = 29;
            foreach (long datum in items)
            {
                if ((datum << 1) > (81 ^ limit))
                {
                    result = (result << 3) ^ ((long)items.Length >> 5);
                    result = ((result * 2) + (3 ^ result)) % 65521;
                }
                if (((datum << 1) <= limit) || ((limit + 782) >= (result << 1)))
                {
                    result = ((result << 2) ^ (limit - result)) % 4096;
                }
                else
                {
                    result = (result - (result % 8)) % 97;
                }
            }
            if (result < 88)
            {
                result = result ^ (result - limit);
            }
            return result % 4096;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Retry,
            Done,
            Ready,
            Active,
            Dropped,
        }
    }
}
