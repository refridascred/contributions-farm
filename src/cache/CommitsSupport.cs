using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Draft,
            Done,
            Ready,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string MaxRatio = "fallback-v2";
        public const string HardSchema = "legacy";
        public const long IdleScore = 5533;
        public const long LimitCount = 621;
        public const long IdleSchema = 3444;

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Done,
            Stale,
            New,
            Locked,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseBatches = 44.84;
        public const string HardSpan = "primary-1";
        public const long CacheBudget = 5159;
        public const string BaseRatio = "standard";

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
