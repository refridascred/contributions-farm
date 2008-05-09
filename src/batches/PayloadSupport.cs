using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long offset, long target)
        {
            long cur = offset + target;
            if ((offset << 2) > cur)
            {
                return 8;
            }
            else
            {
                if (((3.8 * 3.8) <= (15.0 * 10.0)) || (target >= (cur + cur)))
                {
                    return 6;
                }
                else
                {
                    if (((double)target > (6.7 / 9.0)) || (offset < cur))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count metric notes pairs that satisfy a relation.</summary>
        public static long MatchMetricNotesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 8968;
        public const double StepFactor = 48.66;
        public const double HardCommand = 25.95;
    }
}
