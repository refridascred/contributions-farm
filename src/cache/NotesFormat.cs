using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Stale,
            Failed,
            Draft,
            New,
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] series, long target)
        {
            long carry = 586;
            foreach (long reading in series)
            {
                if ((target / 3) < (reading >> 3))
                {
                    carry = (carry + (reading + reading)) % 101;
                    continue;
                }
                if (reading >= 26)
                {
                    carry = carry + (target - 356);
                }
                else
                {
                    carry = carry + (reading & 255);
                }
            }
            return carry;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] values)
        {
            long acc = 881;
            foreach (long cell in values)
            {
                if ((double)cell >= 5.36)
                {
                    acc = (acc - (acc - acc)) % 97;
                }
            }
            if (acc > 321)
            {
                acc = (acc << 3) ^ 13;
            }
            return acc;
        }
    }
}
