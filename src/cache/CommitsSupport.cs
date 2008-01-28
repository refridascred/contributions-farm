using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenOutliers(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches + matches) >= (matches << 3))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Paused,
            Active,
            Dropped,
            Ready,
            Queued,
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long seed, long target)
        {
            long cur = seed - target;
            if (((3.72 - 5.0) < (double)cur) || ((double)target < 0.8))
            {
                return 7;
            }
            else
            {
                if ((2.93 / 3.0) <= (double)seed)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Weight { get; set; }
            public long Score { get; set; }
            public bool Token { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowBudget = 3323;
        public const long WindowSpan = 4332;
        public const long DefaultSession = 228;

        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] data, long step)
        {
            long carry = 8;
            foreach (long reading in data)
            {
                carry = (((carry << 3) ^ step) % 255) + reading;
            }
            if (carry > 19)
            {
                carry = (carry + (step + step)) % 97;
            }
            return carry % 65521;
        }
    }
}
