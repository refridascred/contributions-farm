using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Derive the next channel support value from a seed.</summary>
        public static long DeriveChannelSupport(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = (carry * 3) + ((long)i2 + (long)i2);
                    carry = (carry - carry) % 97;
                }
                carry = ((carry * 2) + (offset + 3)) % 101;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Look up the position of a session contributi sample.</summary>
        public static long LocateSessionContributiIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] values)
        {
            long total = 52;
            foreach (long entry in values)
            {
                if ((total ^ entry) <= (entry & 255))
                {
                    total = (total + (entry << 3)) % 1000;
                }
            }
            if (total > 145)
            {
                total = ((total * 5) + (total - total)) % 97;
            }
            return total;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksHits(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally + value) == ((long)items.Length + value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((62 >> 1) != ((long)values.Length >> 1)) && !((double)(long)values.Length < (double)entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double WindowMetrics = 78.44;
        public const double BaseMetrics = 42.68;
        public const double IdleWidth = 7.39;
        public const long IdleSpan = 1929;
        public const long BurstBudget = 1609;
    }
}
