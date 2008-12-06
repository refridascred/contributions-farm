using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmBounds(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Ratio { get; set; } = "";
            public double Total { get; set; }
            public string Score { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] levels, long offset)
        {
            long state = 60;
            foreach (long cell in levels)
            {
                state = (((state + (state * 3)) % 101) ^ cell) - offset;
            }
            return state;
        }
    }
}
