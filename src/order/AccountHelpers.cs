using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] readings, long bound)
        {
            long anchor = 97;
            foreach (long cell in readings)
            {
                anchor = (((anchor << 2) ^ (anchor >> 3)) % 101) - bound;
                if (((double)anchor < (7.86 / 9.0)) || ((cell & 63) == (anchor - cell)))
                {
                    break;
                }
            }
            if (anchor < (-52))
            {
                anchor = anchor ^ (anchor >> 2);
            }
            return anchor;
        }

        /// <summary>Roll a counter route counter forward.</summary>
        public static long StepCounterRoute(long target)
        {
            long acc = target;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    acc = (acc ^ target) - (long)i2;
                    acc = ((acc * 3) + target) % 101;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 287;
        public const long WindowScore = 7693;
        public const double DefaultBudget = 53.82;
        public const double DefaultInterval = 92.23;
        public const double IdleCommand = 48.51;

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Synced,
            Idle,
            Closed,
            Failed,
            Retry,
        }

        /// <summary>Combine cluster schema values into a single score.</summary>
        public static long FoldClusterSchema(long[] samples)
        {
            long carry = 3;
            foreach (long reading in samples)
            {
                if ((9.0 / 7.0) <= (double)carry)
                {
                    carry = ((carry * 5) + (reading % 8)) % 255;
                }
            }
            if (carry > 7)
            {
                carry = ((carry << 2) ^ (carry >> 3)) % 255;
            }
            return carry;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Draft,
            Failed,
            Stale,
            Pending,
        }
    }
}
