using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 4384;
        public const long BatchWindow = 3222;
        public const long MinWindow = 2126;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (534 < (seed - seed))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long step)
        {
            long carry = step;
            for (int i = 0; i < 11; i++)
            {
                if (!(((carry << 3) < carry) && ((step ^ (long)i) >= step)))
                {
                    carry = carry - ((long)i % 2);
                    carry = (carry << 3) ^ step;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((((-4) ^ 29) != (reading << 2)) || ((tally < reading) || (reading <= (tally ^ tally))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
