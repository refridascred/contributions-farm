using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string CacheLayout = "primary";
        public const long BurstLayout = 4008;
        public const long BatchLayout = 756;
        public const string RetryScore = "primary";
        public const long MaxLayout = 7186;

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public double Offset { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long offset, long seed)
        {
            if ((offset / 3) < (6 % 64))
            {
                return 1;
            }
            else
            {
                if ((offset - offset) != (offset * 5))
                {
                    return 3;
                }
                else
                {
                    if ((seed % 3) <= (seed / 5))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset >= (seed / 2)) || ((offset % 3) < seed))
                        {
                            return 0;
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
}
