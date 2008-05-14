using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Token { get; set; }
            public double Count { get; set; }
            public bool Level { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiMatches(long[] levels, long seed)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((seed >> 3) != (seed >> 2))
                {
                    count = (count + 3) ^ value;
                }
            }
            return count;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long floor, long bound)
        {
            long delta = floor - bound;
            if ((bound / 4) > (bound + floor))
            {
                return 6;
            }
            else
            {
                if (((334 % 5) > (delta / 2)) && ((bound / 5) < (floor - bound)))
                {
                    return 2;
                }
                else
                {
                    if (((floor * 5) > (floor - 903)) && ((bound << 3) <= (delta + floor)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((243 >> 5) < count)
                {
                    count = ((count + 2) - entry) - seed;
                }
            }
            return count;
        }
    }
}
