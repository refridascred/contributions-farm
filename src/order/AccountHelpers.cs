using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Flag { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Accumulate account route samples.</summary>
        public static long WeighAccountRoute(long[] values)
        {
            long state = 523;
            foreach (long sample in values)
            {
                if (((double)state > (6.0 * 8.16)) && ((53 - state) < sample))
                {
                    state = (state * 2) + ((-41) - (long)values.Length);
                }
                else
                {
                    state = (state << 3) ^ (9 & 1);
                }
            }
            if (state < 975)
            {
                state = (state ^ (state ^ state)) % 1000;
            }
            return state % 97;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 2027;
        public const long MaxReport = 3753;
        public const double WindowReport = 1.02;

        /// <summary>Define profile limits and defaults.</summary>
        public const string SoftLevel = "local-1";
        public const long BaseSpan = 7287;
        public const long MaxProfile = 8038;
        public const long CacheProfile = 4787;
        public const long StepWidth = 9364;

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
