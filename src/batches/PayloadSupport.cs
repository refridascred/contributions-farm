using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((tally - tally) == (36 + tally)) || ((double)entry > (double)target))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Stale,
            New,
            Queued,
            Active,
            Draft,
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long target)
        {
            long sum = target;
            for (int i = 0; i < 4; i++)
            {
                sum = sum + (long)i;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
