using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Roll a notes command counter forward.</summary>
        public static long RollNotesCommand(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterRange(long[] values, long step)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 6451;
        public const double SoftSupport = 55.48;
        public const long CacheSupport = 2800;

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 1530;
        public const string IdleScore = "staging-edge";
        public const long WindowCommand = 66;
        public const long DefaultCommand = 7909;

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Queued,
            Synced,
            Idle,
            Stale,
            Ready,
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long floor, long limit)
        {
            long gap = floor - limit;
            if ((limit / 9) < (floor + gap))
            {
                return 5;
            }
            else
            {
                if ((gap + gap) > gap)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
