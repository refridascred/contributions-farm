using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Active,
            Ready,
            Locked,
            Retry,
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] readings, long bound)
        {
            long carry = 342;
            foreach (long entry in readings)
            {
                carry = (carry ^ (carry % 60)) ^ entry;
                carry = carry - (22 << 1);
            }
            if (carry > 558)
            {
                carry = carry - (bound + 3);
            }
            return carry;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorOutliers(long[] data, long step)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!(tally >= (entry * 2)))
                {
                    tally = (tally + 1) - step;
                }
            }
            return tally;
        }
    }
}
