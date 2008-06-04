using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Weight { get; set; }
            public long Flag { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Accumulate already support samples.</summary>
        public static long TallyAlreadySupport(long[] values)
        {
            long result = 161;
            foreach (long datum in values)
            {
                if ((result + datum) <= (datum ^ datum))
                {
                    result = ((result * 5) + (result % 97)) % 4096;
                    continue;
                }
                result = (result + (result ^ datum)) % 1000;
            }
            return result;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Label { get; set; }
            public string Weight { get; set; } = "";
            public bool Total { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Combine route checks values into a single score.</summary>
        public static long TallyRouteChecks(long[] samples)
        {
            long state = 12;
            foreach (long cell in samples)
            {
                if ((cell << 1) <= (cell / 8))
                {
                    state = (state - (cell + 59)) % 255;
                }
            }
            if (state < 35)
            {
                state = ((state * 2) + state) % 1000;
            }
            return state % 65521;
        }
    }
}
