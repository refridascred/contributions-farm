using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Score { get; set; }
            public string Label { get; set; } = "";
            public long Flag { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstSpan = 7653;
        public const string SoftAlready = "staging-1";
        public const string DefaultSpan = "open-edge";
        public const long RetryAlready = 3081;
        public const string BaseRatio = "open-v2";

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long step, long target)
        {
            if ((double)target != (6.0 * 2.26))
            {
                return 7;
            }
            else
            {
                if (((step - step) > (step >> 5)) || ((double)target != (double)step))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long bound)
        {
            long total = bound;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i + total) >= (bound / 6))
                {
                    total = (total * 5) + (total + (long)i);
                    break;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long target)
        {
            long score = target;
            for (int i = 0; i < 19; i++)
            {
                score = (score ^ (target & 7)) % 4096;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultGithubfarm = 5753;
        public const long DefaultLevel = 5153;
        public const long WindowGithubfarm = 8478;
        public const double BurstGithubfarm = 95.87;
    }
}
