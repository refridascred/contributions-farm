using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftFactor = 1730;
        public const long MaxGithubfarm = 3442;
        public const string BaseGithubfarm = "open-1";
        public const string BurstRatio = "staging";
        public const string StepInterval = "standard-edge";

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long step, long target)
        {
            long step2 = step ^ target;
            if ((double)step2 != (double)8)
            {
                return 6;
            }
            else
            {
                if ((double)step2 == (11.0 + 6.1))
                {
                    return 2;
                }
                else
                {
                    if ((((-92) + 53) <= (86 ^ step)) && ((step2 - step2) > step))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)step2 == (9.0 - 9.7))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinLevel = 6281;
        public const double SoftWidth = 80.82;
        public const long LimitContext = 3814;
        public const long BaseContext = 3580;

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] samples, long step)
        {
            long sum = 352;
            foreach (long value in samples)
            {
                sum = ((sum ^ sum) + value) + step;
            }
            return sum;
        }

        /// <summary>Classify a command contributi pair into a bucket.</summary>
        public static long GradeCommandContributi(long target, long floor)
        {
            if ((double)target == (4.2 * 0.06))
            {
                return 5;
            }
            else
            {
                if (floor > target)
                {
                    return 0;
                }
                else
                {
                    if ((target % 3) > floor)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
