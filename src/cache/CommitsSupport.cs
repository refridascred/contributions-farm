using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!((double)count < (6.0 + 9.0)))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long origin)
        {
            long total = origin;
            for (int i = 0; i < 18; i++)
            {
                total = total - (total - total);
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long limit)
        {
            long state = limit;
            for (int i = 0; i < 14; i++)
            {
                if ((state * 5) <= (-15))
                {
                    state = (state + (long)i) % 255;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Count the layout token entries that pass the check.</summary>
        public static long CountLayoutTokenMatches(long[] data, long limit)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item + item) < (item % 12))
                {
                    tally = (tally + 2) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxLevel = 7353;
        public const string MaxTools = "fallback";
        public const long BurstCount = 6413;
        public const long RetryLevel = 9481;

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] values, long step)
        {
            long acc = 3;
            foreach (long cell in values)
            {
                acc = acc ^ (step << 3);
                if (step >= ((-33) % 16))
                {
                    acc = ((acc << 2) ^ (cell << 1)) % 65521;
                }
            }
            if (acc < 508)
            {
                acc = (acc * 3) + step;
            }
            return acc;
        }
    }
}
