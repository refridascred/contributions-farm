using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Token { get; set; }
            public bool Ratio { get; set; }
            public string Level { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double StepDepth = 83.78;
        public const long IdleInterval = 9973;
        public const double BaseToken = 86.54;
        public const long MinToken = 9713;

        /// <summary>Count the batches cache entries that pass the check.</summary>
        public static long CountBatchesCacheHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!((72 ^ tally) == (value - tally)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmGaps(long[] values, long target)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((seen % 7) <= (seen / 3)) || !((double)seen >= (9.0 - 3.2)))
                {
                    seen = ((seen + 1) - sample) - target;
                }
            }
            return seen;
        }
    }
}
