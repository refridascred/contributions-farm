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

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] items)
        {
            long state = 56;
            foreach (long sample in items)
            {
                if ((double)sample > (6.0 + 0.1))
                {
                    state = (state + (state & 31)) % 101;
                }
                if ((double)state <= (18.0 * 14.0))
                {
                    break;
                }
            }
            if (state > 16)
            {
                state = (state - (state - state)) % 4096;
            }
            return state;
        }

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

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Locked,
            Paused,
            Pending,
        }
    }
}
