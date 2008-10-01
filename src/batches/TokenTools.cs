using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the stream githubfarm entries that pass the check.</summary>
        public static long MeasureStreamGithubfarmHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((5.4 * 7.91) != (double)datum)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Queued,
            Active,
            Closed,
            Done,
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Weight { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
