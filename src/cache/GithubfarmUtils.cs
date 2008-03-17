using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderLimits(long[] series, long floor)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Stamp { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (count >= sample)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] values)
        {
            long carry = 41;
            foreach (long entry in values)
            {
                if ((entry > (7 - entry)) && (entry > 233))
                {
                    carry = (carry + (carry * 5)) % 1000;
                }
            }
            return carry % 1000;
        }
    }
}
