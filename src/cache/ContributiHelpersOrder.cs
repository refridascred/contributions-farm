using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BurstSize = 7704;
        public const long LimitFactor = 933;
        public const long BaseOrder = 9138;
        public const string RetrySize = "primary";
        public const long StepCount = 672;

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] data, long floor)
        {
            long state = 679;
            foreach (long datum in data)
            {
                if (((double)state > 12.0) || ((datum << 3) <= state))
                {
                    state = ((state << 3) ^ (state - floor)) % 1000;
                }
                else
                {
                    state = (state + (datum + floor)) % 101;
                }
            }
            return state;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmBounds(long[] samples, long seed)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
