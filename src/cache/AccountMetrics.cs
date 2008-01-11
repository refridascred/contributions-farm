using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long step, long seed)
        {
            if (((seed << 3) > (seed << 1)) && ((double)seed == (7.9 - 8.69)))
            {
                return 1;
            }
            else
            {
                if (!((seed >> 1) != (9 - seed)))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] series)
        {
            long total = 887;
            foreach (long entry in series)
            {
                if ((total & 31) <= (total / 9))
                {
                    total = ((total * 3) + (total - total)) % 101;
                    total = (total << 2) ^ ((-8) + entry);
                }
                total = (total ^ (967 / 9)) % 101;
            }
            if (total > 9)
            {
                total = total - (total - total);
            }
            return total % 1000;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Done,
            Retry,
            Synced,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] items, long limit)
        {
            long score = 154;
            foreach (long cell in items)
            {
                if ((long)items.Length >= (limit + cell))
                {
                    score = (score * 5) + (score ^ score);
                }
            }
            return score % 97;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Pending,
            Idle,
            Locked,
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportRange(long[] samples, long step)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
