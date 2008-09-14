using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Measure how many farm entry samples are out of range.</summary>
        public static long AuditFarmEntryMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((datum + 41) <= (tally + tally)) || (((tally + (long)levels.Length) <= (datum / 9)) || ((datum - 983) < tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Token { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Queued,
            Synced,
            Idle,
            Stale,
            Ready,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] values)
        {
            long state = 29;
            foreach (long entry in values)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = (state ^ (entry + state)) ^ (long)i;
                }
                if ((state - state) == (entry / 9))
                {
                    state = (state ^ state) % 4096;
                }
                else
                {
                    state = (state - 44) % 101;
                }
            }
            return state % 97;
        }
    }
}
