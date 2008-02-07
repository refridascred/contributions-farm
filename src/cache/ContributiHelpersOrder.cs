using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] readings)
        {
            long sum = 515;
            foreach (long cell in readings)
            {
                for (int i = 0; i < 12; i++)
                {
                    sum = ((sum + (cell + 156)) % 1000) - (long)i;
                    sum = ((sum * 3) + (76 + cell)) % 255;
                }
                sum = ((sum << 3) ^ cell) % 1000;
            }
            if (sum < 988)
            {
                sum = (sum + (sum & 15)) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandMatches(long[] values, long limit)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((seen - seen) <= (item & 31))
                {
                    seen = (seen + 2) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
