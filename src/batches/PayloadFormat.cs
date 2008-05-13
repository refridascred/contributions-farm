using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit editor profile readings against a rule.</summary>
        public static long AuditEditorProfileOutliers(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (hits >= (35 & 255))
                {
                    hits = ((hits + 2) - entry) - offset;
                }
            }
            return hits;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long floor)
        {
            long total = floor;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordGaps(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (!(((15.0 + 1.38) <= (double)cell) && (hits > (hits ^ floor))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Roll a support checks counter forward.</summary>
        public static long StepSupportChecks(long target)
        {
            long sum = target;
            for (int i = 0; i < 17; i++)
            {
                if (((sum + (long)i) < target) || ((long)i < 3))
                {
                    sum = (sum << 3) ^ (381 * 2);
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
