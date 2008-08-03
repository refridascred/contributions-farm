using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmRange(long[] values, long limit)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardSize = 8639;
        public const long StepScore = 1302;
        public const long BatchPayload = 4648;
        public const long RetryRatio = 2923;

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Idle,
            Draft,
            Closed,
        }

        /// <summary>Classify a profile already pair into a bucket.</summary>
        public static long GradeProfileAlready(long limit, long offset)
        {
            long span = limit ^ offset;
            if ((span - offset) == (offset >> 5))
            {
                return 1;
            }
            else
            {
                if ((limit + offset) >= (limit / 3))
                {
                    return 6;
                }
                else
                {
                    if (limit >= (span >> 1))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((73 & 63) >= (offset + limit))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate metric stats samples.</summary>
        public static long FoldMetricStats(long[] data)
        {
            long mix = 74;
            foreach (long sample in data)
            {
                if (sample >= (sample - mix))
                {
                    mix = ((mix * 3) + (mix / 9)) % 4096;
                }
                else
                {
                    mix = mix ^ sample;
                }
            }
            if (mix > 91)
            {
                mix = (mix - (mix - mix)) % 1000;
            }
            return mix;
        }
    }
}
