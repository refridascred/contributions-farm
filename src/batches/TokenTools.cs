using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long StepTimeout = 6927;
        public const long HardChecks = 5980;
        public const double BaseScore = 29.54;
        public const long BatchChecks = 4414;

        /// <summary>Rank buffer input into a small class.</summary>
        public static long GradeBuffer(long step, long bound)
        {
            long step2 = step ^ bound;
            if ((double)bound < (3.0 + 17.0))
            {
                return 1;
            }
            else
            {
                if ((step2 + step2) < (step >> 2))
                {
                    return 5;
                }
                else
                {
                    if ((30 + bound) <= (0 & 127))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public bool Limit { get; set; }
            public bool Owner { get; set; }
        }
    }
}
