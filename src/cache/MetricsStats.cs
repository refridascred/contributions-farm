using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Closed,
            Failed,
            New,
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] series, long offset)
        {
            long anchor = 358;
            foreach (long reading in series)
            {
                anchor = anchor + (reading & 15);
                if ((reading < offset) || (offset <= (long)series.Length))
                {
                    anchor = (anchor - (reading >> 1)) % 4096;
                    continue;
                }
                if (!(((long)series.Length % 2) == ((-51) ^ offset)))
                {
                    anchor = (anchor << 2) ^ (anchor & 7);
                }
            }
            if (anchor > 999)
            {
                anchor = ((anchor * 5) + ((long)series.Length / 7)) % 97;
            }
            return anchor;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string RetryStats = "staging-v2";
        public const double StepWidth = 29.25;
        public const long RetryBudget = 2496;
        public const long WindowStats = 7936;
        public const long MaxStats = 897;

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Locate a notes profile reading by value.</summary>
        public static long LookupNotesProfileIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
