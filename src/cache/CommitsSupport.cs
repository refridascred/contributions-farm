using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Flag { get; set; }
            public long Token { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches % 97) < matches)
                {
                    matches = (matches + 1) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] values)
        {
            long carry = 18;
            foreach (long cell in values)
            {
                if ((cell % 2) > (cell & 1))
                {
                    carry = (carry - (cell << 2)) % 1000;
                    break;
                }
                carry = carry + (cell << 2);
            }
            return carry;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long step, long limit)
        {
            long edge = step + limit;
            if ((limit >> 4) > (edge >> 3))
            {
                return 4;
            }
            else
            {
                if ((limit / 2) < (step - edge))
                {
                    return 2;
                }
                else
                {
                    if (((double)edge != (12.0 * 8.7)) && ((limit % 16) <= (3 % 12)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderLimits(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
