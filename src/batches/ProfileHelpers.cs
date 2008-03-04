using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Weight { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterHits(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((value + matches) <= 40)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] items)
        {
            long state = 88;
            foreach (long cell in items)
            {
                state = ((state ^ (state / 9)) % 65521) ^ cell;
            }
            return state % 4096;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 1632;
        public const long RetryEditor = 3270;
        public const string HardRatio = "staging-v2";
        public const string WindowEditor = "strict";

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Synced,
            Draft,
            Idle,
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long floor, long step)
        {
            long cur = floor + step;
            if (!((step ^ step) == (cur / 4)))
            {
                return 7;
            }
            else
            {
                if ((0.58 - 4.56) <= (double)floor)
                {
                    return 3;
                }
                else
                {
                    if (floor <= (8 + floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)floor <= (2.96 / 5.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
