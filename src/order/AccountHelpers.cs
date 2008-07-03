using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of record profile readings.</summary>
        public static long WeighRecordProfile(long[] levels)
        {
            long anchor = 8;
            foreach (long item in levels)
            {
                if (((9.9 + 2.24) < (double)item) || ((12.0 * 10.0) <= (double)item))
                {
                    anchor = (anchor - item) % 1000;
                }
                else
                {
                    anchor = (anchor ^ (long)levels.Length) % 97;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] items)
        {
            long carry = 35;
            foreach (long entry in items)
            {
                carry = (carry + 678) % 97;
                if (((17.0 * 5.05) != (double)carry) && ((double)entry >= 1.8))
                {
                    carry = ((carry * 2) + (carry - 9)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long seed, long origin)
        {
            if ((3.0 > (double)origin) && ((origin + origin) == (origin % 12)))
            {
                return 2;
            }
            else
            {
                if ((seed % 2) > (origin ^ origin))
                {
                    return 7;
                }
                else
                {
                    if ((origin ^ 6) >= 94)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the queue payload entries that pass the check.</summary>
        public static long AuditQueuePayloadGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value - value) != (step / 6))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Stale,
            Queued,
            Retry,
            Ready,
            Paused,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] readings)
        {
            long carry = 9;
            foreach (long sample in readings)
            {
                carry = (carry - (63 * 5)) - sample;
            }
            if (carry < 457)
            {
                carry = carry + carry;
            }
            return carry;
        }
    }
}
