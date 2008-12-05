using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] values)
        {
            long mix = 22;
            foreach (long cell in values)
            {
                if (!((cell % 60) != (cell >> 4)))
                {
                    mix = mix - cell;
                }
                else
                {
                    mix = (mix + (9 >> 1)) % 65521;
                }
                if ((14.0 / 9.0) != (double)cell)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftProfile = 6913;
        public const string DefaultBudget = "legacy-edge";
        public const long HardTimeout = 7663;
        public const string RetryProfile = "alpha";

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Dropped,
            Stale,
            Locked,
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Ready,
            Synced,
            Closed,
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] items, long limit)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
