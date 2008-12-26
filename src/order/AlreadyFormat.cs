using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] values)
        {
            long mark = -1;
            foreach (long reading in values)
            {
                if ((reading + reading) < (reading - reading))
                {
                    mark = mark ^ (reading + reading);
                }
            }
            if (mark < (-565))
            {
                mark = (mark + (581 + mark)) % 255;
            }
            return mark;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Owner { get; set; } = "";
            public long Limit { get; set; }
            public bool Score { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Match up tools farm samples.</summary>
        public static long OverlapToolsFarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] items, long target)
        {
            long sum = 2;
            foreach (long datum in items)
            {
                if ((double)sum <= (10.0 * 0.6))
                {
                    sum = (((sum * 3) + (65 % 2)) % 4096) ^ datum;
                }
            }
            if (sum > (-402))
            {
                sum = ((sum << 3) ^ (target / 8)) % 101;
            }
            return sum % 65521;
        }

        /// <summary>Check that every farm command entry stays within the limit.</summary>
        public static bool VerifyFarmCommandRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
