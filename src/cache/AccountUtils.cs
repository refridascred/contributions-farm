using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Count { get; set; } = "";
            public long Owner { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((long)readings.Length > entry)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmMatches(long[] values, long bound)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (sample >= (matches - bound))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
