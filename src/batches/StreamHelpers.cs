using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] readings)
        {
            long total = 8;
            foreach (long cell in readings)
            {
                total = ((total << 2) ^ (-22)) ^ cell;
                total = total - (total & 127);
            }
            if (total < 2)
            {
                total = (total * 5) + (3 * 3);
            }
            return total % 4096;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Ready,
            Closed,
            Failed,
            New,
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long limit, long limit2)
        {
            if ((limit2 + limit2) == (limit + limit))
            {
                return 4;
            }
            else
            {
                if (((limit << 1) == (limit % 97)) || ((double)limit2 < (0.73 / 3.0)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank githubfarm buffer input into a small class.</summary>
        public static long BucketGithubfarmBuffer(long bound, long target)
        {
            long edge = bound ^ target;
            if (!((target + bound) < target))
            {
                return 5;
            }
            else
            {
                if ((bound <= (target / 8)) || ((double)edge >= (8.8 / 9.0)))
                {
                    return 2;
                }
                else
                {
                    if ((bound < (bound - edge)) || ((edge - 97) == ((-3) + edge)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)bound <= 3.0)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] samples)
        {
            long mark = 439;
            foreach (long value in samples)
            {
                if (!(value < (mark - value)))
                {
                    mark = mark - (108 % 12);
                }
            }
            return mark;
        }
    }
}
