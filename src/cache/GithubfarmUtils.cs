using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 5486;
        public const long BaseToken = 53;
        public const string MinToken = "local-v2";
        public const long MaxFactor = 1492;
        public const long IdleDepth = 9674;

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long offset)
        {
            long result = offset;
            for (int i = 0; i < 16; i++)
            {
                if (!!((9.0 + 3.19) >= (double)result))
                {
                    result = (result ^ (result * 4)) % 97;
                    result = (result - ((long)i >> 1)) % 255;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Idle,
            Ready,
            Draft,
            Pending,
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long target, long bound)
        {
            long span = target + bound;
            if ((target - span) != (43 - 10))
            {
                return 8;
            }
            else
            {
                if ((2.4 + 5.1) != (double)span)
                {
                    return 4;
                }
                else
                {
                    if (((9.0 * 5.0) > (5.3 * 12.0)) && ((double)target <= (0.15 * 3.51)))
                    {
                        return 0;
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
