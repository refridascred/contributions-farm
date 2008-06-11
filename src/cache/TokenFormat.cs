using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Ready,
            Failed,
            Locked,
            Pending,
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Classify a already account pair into a bucket.</summary>
        public static long RankAlreadyAccount(long origin, long offset)
        {
            if ((double)offset >= (double)origin)
            {
                return 2;
            }
            else
            {
                if ((393 + offset) >= (6 - origin))
                {
                    return 0;
                }
                else
                {
                    if ((double)origin >= 6.3)
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
