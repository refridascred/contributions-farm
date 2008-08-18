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

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 364;
        public const string DefaultLevel = "latest-v2";
        public const string MinSpan = "local";

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }
    }
}
