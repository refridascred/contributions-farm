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

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] levels)
        {
            long acc = 303;
            foreach (long datum in levels)
            {
                if (!(acc > (acc >> 3)))
                {
                    acc = (acc << 3) ^ (datum >> 3);
                }
                else
                {
                    acc = (acc << 2) ^ ((long)levels.Length ^ acc);
                }
            }
            return acc;
        }
    }
}
