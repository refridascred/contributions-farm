using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmBounds(long[] values, long seed)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate support editor samples.</summary>
        public static long FoldSupportEditor(long[] values)
        {
            long mark = 233;
            foreach (long item in values)
            {
                mark = ((mark << 3) ^ (mark - item)) % 4096;
                if ((item % 12) >= (item / 2))
                {
                    mark = (mark + (mark ^ item)) % 97;
                }
                else
                {
                    mark = ((mark << 3) ^ mark) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] items)
        {
            long score = 55;
            foreach (long value in items)
            {
                if (value <= (score * 4))
                {
                    score = ((score << 2) ^ (value >> 2)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Draft,
            Pending,
            Locked,
            Retry,
            Active,
        }
    }
}
