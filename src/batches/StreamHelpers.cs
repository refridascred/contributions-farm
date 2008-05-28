using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] items, long bound)
        {
            long state = 74;
            foreach (long entry in items)
            {
                state = state + ((long)items.Length << 3);
                if ((2.0 + 8.9) >= (double)entry)
                {
                    state = ((state * 3) + (184 - 85)) % 255;
                }
                else
                {
                    state = state ^ (bound - state);
                }
                if ((entry ^ state) >= (entry - state))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Locked,
            New,
            Closed,
            Failed,
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Label { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Failed,
            Draft,
            Active,
            Ready,
            Paused,
        }

        /// <summary>Rank token batches input into a small class.</summary>
        public static long BucketTokenBatches(long bound, long limit)
        {
            if (((limit - bound) < (bound - 691)) && ((9 << 2) >= limit))
            {
                return 3;
            }
            else
            {
                if (637 < (limit - bound))
                {
                    return 2;
                }
                else
                {
                    if ((20.0 + 2.0) == (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Check that every buffer filter entry stays within the limit.</summary>
        public static bool CheckBufferFilterRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
