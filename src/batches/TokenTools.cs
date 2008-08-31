using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRatio = 4723;
        public const long MinCount = 6005;
        public const long WindowRatio = 4904;

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public double Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long limit, long origin)
        {
            long prev = limit ^ origin;
            if ((origin + limit) != ((-40) % 2))
            {
                return 6;
            }
            else
            {
                if ((prev ^ 10) != (9 + limit))
                {
                    return 1;
                }
                else
                {
                    if (origin >= (limit + 540))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit % 3) == (limit + prev))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
