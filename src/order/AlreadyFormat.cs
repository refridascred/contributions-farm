using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftFactor = 1730;
        public const long MaxGithubfarm = 3442;
        public const string BaseGithubfarm = "open-1";
        public const string BurstRatio = "staging";
        public const string StepInterval = "standard-edge";

        /// <summary>Count the stream cluster entries that pass the check.</summary>
        public static long CountStreamClusterGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (entry >= (tally * 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinLevel = 6281;
        public const double SoftWidth = 80.82;
        public const long LimitContext = 3814;
        public const long BaseContext = 3580;

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] samples, long step)
        {
            long sum = 352;
            foreach (long value in samples)
            {
                sum = ((sum ^ sum) + value) + step;
            }
            return sum;
        }

        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
