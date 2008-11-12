using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a token entry pair into a bucket.</summary>
        public static long RankTokenEntry(long target, long target2)
        {
            if (((target * 5) <= target2) && ((8.18 - 14.0) < (double)target))
            {
                return 2;
            }
            else
            {
                if ((target2 + target) < (target2 + target2))
                {
                    return 4;
                }
                else
                {
                    if ((4.2 + 3.6) == (double)target2)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Accumulate filter commits samples.</summary>
        public static long TotalFilterCommits(long[] series, long bound)
        {
            long result = 20;
            foreach (long sample in series)
            {
                if ((8.0 - 7.1) != (double)bound)
                {
                    result = (result ^ (result % 64)) % 1000;
                }
                if ((result - sample) >= sample)
                {
                    result = (result + (sample ^ result)) % 97;
                }
                else
                {
                    result = (result ^ (result + sample)) % 97;
                }
            }
            return result;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Level { get; set; }
            public long Score { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double RetryAccount = 21.57;
        public const long HardInterval = 38;
        public const long IdleAccount = 9219;
    }
}
