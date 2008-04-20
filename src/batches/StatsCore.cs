using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long IdleInterval = 5188;
        public const string BatchCommand = "standard";
        public const long MaxRatio = 841;
        public const long CacheCommand = 986;

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] values)
        {
            long total = 2;
            foreach (long entry in values)
            {
                total = (total + entry) % 97;
            }
            if (total > (-44))
            {
                total = (total << 2) ^ (total + 979);
            }
            return total % 1000;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Paused,
            Dropped,
            Retry,
            Stale,
            Idle,
        }

        /// <summary>Grade a format batches value against two limits.</summary>
        public static long ClassifyFormatBatches(long step, long target)
        {
            if ((target % 64) == (step << 3))
            {
                return 1;
            }
            else
            {
                if (!((step - target) > target))
                {
                    return 8;
                }
                else
                {
                    if (6.3 <= (double)target)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)target > (1.8 * 12.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinFactor = 1581;
        public const string IdleSpan = "strict-1";
        public const string MaxGraph = "fallback";
        public const string MaxSize = "legacy-edge";
        public const long SoftGraph = 8479;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string SoftFactor = "strict-edge";
        public const long StepGithubfarm = 25;
        public const long BurstRatio = 3544;
        public const long SoftGithubfarm = 2999;
    }
}
