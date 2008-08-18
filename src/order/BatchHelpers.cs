using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long floor, long limit)
        {
            if (limit >= (limit - floor))
            {
                return 0;
            }
            else
            {
                if (floor <= (limit % 60))
                {
                    return 3;
                }
                else
                {
                    if ((limit + floor) <= floor)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)floor <= (0.85 - 10.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long target, long seed)
        {
            long diff = target - seed;
            if ((2.3 * 4.0) != (double)seed)
            {
                return 4;
            }
            else
            {
                if ((diff > (diff % 100)) && (diff < (seed + 588)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }
    }
}
