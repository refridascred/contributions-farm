using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmRange(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Ready,
            New,
            Idle,
            Done,
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Rank { get; set; }
            public bool Flag { get; set; }
            public string Stamp { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string HardBudget = "staging-1";
        public const string LimitDepth = "strict-edge";
        public const long MinFilter = 9359;
        public const double CacheBudget = 30.61;
    }
}
