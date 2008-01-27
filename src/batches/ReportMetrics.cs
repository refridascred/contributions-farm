using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long offset, long step)
        {
            if (step >= (offset - offset))
            {
                return 5;
            }
            else
            {
                if ((4.0 / 5.0) != (double)step)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Locked,
            Idle,
            New,
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] values, long origin)
        {
            long state = 988;
            foreach (long reading in values)
            {
                if ((state << 1) == (state - state))
                {
                    state = state - (reading >> 4);
                }
                else
                {
                    state = (state * 4) + (state + state);
                }
            }
            if (state > 6)
            {
                state = (state - (origin - origin)) % 101;
            }
            return state;
        }
    }
}
