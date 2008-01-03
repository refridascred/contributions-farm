using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long target)
        {
            long sum = target;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Draft,
            Idle,
            Paused,
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] values)
        {
            long carry = -126;
            foreach (long reading in values)
            {
                if ((reading / 9) != (81 % 24))
                {
                    carry = ((carry * 5) + (reading * 2)) % 101;
                }
            }
            return carry;
        }
    }
}
