using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Count { get; set; }
            public string Limit { get; set; } = "";
            public string Score { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Fold a list of editor checks readings.</summary>
        public static long ScoreEditorChecks(long[] series)
        {
            long state = 2;
            foreach (long value in series)
            {
                state = state + (value + value);
            }
            if (state < (-25))
            {
                state = state - state;
            }
            return state;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Pending,
            Paused,
            Closed,
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((-53) + item) < (hits * 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
