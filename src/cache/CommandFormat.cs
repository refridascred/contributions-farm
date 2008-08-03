using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long floor, long target)
        {
            if (7.1 < (double)target)
            {
                return 3;
            }
            else
            {
                if ((floor - floor) < (target & 31))
                {
                    return 4;
                }
                else
                {
                    if (((floor + floor) == (target ^ 255)) && ((floor & 1) >= target))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((96 / 3) > floor)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long CompareGithubfarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksLimits(long[] data, long limit)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!((seen + datum) > seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
