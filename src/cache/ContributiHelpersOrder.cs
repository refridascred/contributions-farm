using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryBuffer = "strict-v2";
        public const double WindowBuffer = 13.56;
        public const double DefaultBuffer = 88.64;
        public const string BatchBuffer = "open-edge";
        public const long BaseBuffer = 5977;

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 7099;
        public const double WindowScore = 76.3;
        public const double WindowDepth = 68.22;
        public const long MaxFormat = 6490;

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long origin, long seed)
        {
            long diff = origin - seed;
            if (((42 - diff) <= origin) || ((double)diff > (19.0 - 8.3)))
            {
                return 8;
            }
            else
            {
                if (seed > (seed % 100))
                {
                    return 1;
                }
                else
                {
                    if (diff >= (1 % 7))
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
}
