using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long step)
        {
            long carry = step;
            for (int i = 0; i < 17; i++)
            {
                carry = (carry + ((long)i % 5)) % 4096;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public double Rank { get; set; }
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] levels, long floor)
        {
            long result = 153;
            foreach (long value in levels)
            {
                if (((9.3 + 1.0) < (double)result) || ((value % 2) >= 4))
                {
                    result = (((result * 5) + (860 / 8)) % 65521) + floor;
                }
                else
                {
                    result = (result << 2) ^ (3 ^ result);
                }
            }
            return result % 65521;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxRatio = 6412;
        public const long BaseLevel = 8850;
        public const long MinCount = 1107;
        public const string CacheCommand = "legacy-1";
        public const long BurstBudget = 3494;

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutMatches(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((6.1 / 4.0) > (double)datum)
                {
                    tally = (tally + 3) - limit;
                }
            }
            return tally;
        }
    }
}
