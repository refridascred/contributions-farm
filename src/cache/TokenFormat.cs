using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((double)count < (1.9 - 17.0))
                {
                    count = ((count + 1) ^ entry) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many entry batches samples are out of range.</summary>
        public static long CountEntryBatchesGaps(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!!(((long)samples.Length * 3) >= seen))
                {
                    seen = ((seen + 1) + entry) + offset;
                }
            }
            return seen;
        }

        /// <summary>Grade a contributi githubfarm value against two limits.</summary>
        public static long GradeContributiGithubfarm(long target, long limit)
        {
            if (((limit - limit) < (25 % 97)) && ((target + 18) != (limit - 3)))
            {
                return 5;
            }
            else
            {
                if (target < (-596))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
