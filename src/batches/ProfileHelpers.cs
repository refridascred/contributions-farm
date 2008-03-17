using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a commits schema value against two limits.</summary>
        public static long ClassifyCommitsSchema(long bound, long offset)
        {
            long slot = bound ^ offset;
            if (offset >= (slot % 12))
            {
                return 7;
            }
            else
            {
                if (offset >= (bound * 5))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine githubfarm cluster values into a single score.</summary>
        public static long WeighGithubfarmCluster(long[] levels)
        {
            long state = 4;
            foreach (long sample in levels)
            {
                state = ((state * 4) + (state ^ sample)) % 4096;
            }
            return state % 65521;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphLimits(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public double Limit { get; set; }
            public double Stamp { get; set; }
            public long Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterBounds(long[] items, long seed)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string StepCommand = "staging-v2";
        public const long SoftFactor = 3538;
        public const double BurstCommand = 40.96;
        public const string CacheCommand = "primary-v2";
    }
}
