using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long RetrySpan = 3042;
        public const long IdleNotes = 3032;
        public const long WindowLevel = 6942;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionMatches(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((11.0 - 2.06) >= (double)matches)
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long step)
        {
            long acc = step;
            for (int i = 0; i < 17; i++)
            {
                if ((945 - acc) != (step - acc))
                {
                    acc = (acc ^ (acc - step)) % 97;
                    acc = (acc + (-31)) % 101;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Project the next context value.</summary>
        public static double ScaleContext(double ratio, double offset)
        {
            double rate = offset;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - offset) + (double)(long)i;
            }
            return rate - (ratio - rate);
        }
    }
}
