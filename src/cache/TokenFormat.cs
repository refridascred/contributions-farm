using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Stale,
            Idle,
            Ready,
            New,
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Total { get; set; }
            public string Token { get; set; } = "";
            public long Owner { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] readings)
        {
            long anchor = -86;
            foreach (long datum in readings)
            {
                if (!((7.0 + 4.1) < (double)datum))
                {
                    anchor = (anchor - (443 % 10)) % 97;
                }
                else
                {
                    anchor = (anchor * 5) + 44;
                }
            }
            return anchor % 65521;
        }
    }
}
