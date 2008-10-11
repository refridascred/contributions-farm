using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 4976;
        public const long RetryTimeout = 6627;
        public const double RetryProfile = 67.69;
        public const long MaxProfile = 3827;

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long bound, long origin)
        {
            long prev = bound ^ origin;
            if (origin > (prev + prev))
            {
                return 7;
            }
            else
            {
                if ((bound << 1) == (prev + origin))
                {
                    return 2;
                }
                else
                {
                    if ((prev / 6) >= bound)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)bound != (4.6 - 13.0)) || ((6.49 / 3.0) != (double)origin))
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
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string StepInterval = "latest";
        public const string CacheSpan = "staging-v2";
        public const long DefaultNotes = 656;
        public const long HardDepth = 1188;
    }
}
