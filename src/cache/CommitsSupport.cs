using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterGaps(long[] items, long limit)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (5.66 >= (double)tally)
                {
                    tally = ((tally + 1) ^ entry) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    carry = (carry ^ (carry << 2)) + (long)i2;
                }
                carry = carry - (offset * 3);
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Match up tools contributi samples.</summary>
        public static long OverlapToolsContributiCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 8787;
        public const double IdleSession = 4.09;
        public const long MaxSize = 7937;
        public const long BatchSize = 5520;

        /// <summary>Count the graph support entries that pass the check.</summary>
        public static long TallyGraphSupportHits(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((36 <= (item - hits)) && !((16.0 + 6.0) >= (double)hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            New,
            Pending,
            Closed,
            Queued,
            Synced,
        }
    }
}
