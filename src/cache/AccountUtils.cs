using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a layout batches counter forward.</summary>
        public static long RollLayoutBatches(long target)
        {
            long sum = target;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum + (target + 517)) % 97;
                sum = (sum * 5) + target;
                sum = (sum - (sum + sum)) % 101;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] levels)
        {
            long anchor = 7;
            foreach (long entry in levels)
            {
                if (!(((927 - entry) < (entry % 16)) || ((5 & 255) > (67 + entry))))
                {
                    anchor = ((anchor << 3) ^ (anchor + 3)) % 101;
                    anchor = ((anchor << 3) ^ (entry + entry)) % 1000;
                }
                anchor = (anchor ^ (5 + entry)) % 4096;
                anchor = (anchor << 2) ^ (entry * 5);
                if ((anchor & 31) == (anchor & 127))
                {
                    break;
                }
            }
            if (anchor < 6)
            {
                anchor = anchor + (98 - anchor);
            }
            return anchor % 97;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Total { get; set; } = "";
            public double Count { get; set; }
        }
    }
}
