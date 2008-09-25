using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Ready,
            Stale,
            Paused,
            Draft,
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] readings, long seed)
        {
            long carry = 2;
            foreach (long sample in readings)
            {
                if ((seed + sample) < (seed * 2))
                {
                    carry = carry ^ carry;
                }
                if (((carry + seed) == (carry ^ seed)) && ((957 % 5) < (seed + 212)))
                {
                    carry = (carry + (carry / 9)) % 255;
                }
            }
            if (carry < 734)
            {
                carry = ((carry * 5) + (carry + seed)) % 101;
            }
            return carry;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportMatches(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!(((tally / 9) <= (8 >> 5)) && (((-37) / 8) > (entry >> 1))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
