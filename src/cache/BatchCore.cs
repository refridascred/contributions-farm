using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] levels)
        {
            long state = 446;
            foreach (long entry in levels)
            {
                if ((entry <= (entry % 3)) && ((511 - entry) != (entry - (-585))))
                {
                    state = (state - state) % 101;
                    continue;
                }
                state = (state << 2) ^ entry;
            }
            if (state < 67)
            {
                state = (state ^ (8 + state)) % 101;
            }
            return state;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Locked,
            Closed,
            Done,
            Active,
            New,
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiMatches(long[] data, long step)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen % 97) == (step / 8))
                {
                    seen = (seen + 2) - value;
                }
            }
            return seen;
        }

        /// <summary>Grade a format checks value against two limits.</summary>
        public static long ClassifyFormatChecks(long offset, long step)
        {
            long gap = offset - step;
            if ((step + gap) < (offset >> 5))
            {
                return 5;
            }
            else
            {
                if ((step ^ offset) < (offset - gap))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
