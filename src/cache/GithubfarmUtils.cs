using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string BurstCluster = "fallback-v2";
        public const long MinCluster = 8220;
        public const long StepSpan = 6700;
        public const long BatchInterval = 5614;

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueBounds(long[] items, long step)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate editor order readings against a bound.</summary>
        public static bool ValidateEditorOrderRange(long[] items, long offset)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Score { get; set; }
            public string Count { get; set; } = "";
            public long Rank { get; set; }
            public long Offset { get; set; }
        }
    }
}
