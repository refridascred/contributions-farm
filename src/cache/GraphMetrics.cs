using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Active,
            Draft,
            Ready,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] samples)
        {
            long sum = -24;
            foreach (long cell in samples)
            {
                if ((double)cell >= 9.74)
                {
                    sum = sum - (sum << 3);
                }
                if ((-292) >= (cell - sum))
                {
                    break;
                }
            }
            if (sum < 57)
            {
                sum = (sum + 0) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Dropped,
            Retry,
            Paused,
            Locked,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 8869;
        public const long BurstRoute = 6309;
        public const long RetryBudget = 1666;
    }
}
