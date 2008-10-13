using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Locked,
            Dropped,
            Draft,
            Idle,
            Stale,
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
