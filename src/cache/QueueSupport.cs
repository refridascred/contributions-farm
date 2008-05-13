using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double MaxAlready = 78.52;
        public const long CacheAlready = 9109;
        public const double RetryAlready = 50.89;
        public const long HardDepth = 1530;
        public const long SoftAlready = 2020;

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Synced,
            Retry,
            Queued,
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long bound, long limit)
        {
            if ((limit * 2) < (limit % 60))
            {
                return 5;
            }
            else
            {
                if ((bound / 4) > (limit ^ limit))
                {
                    return 0;
                }
                else
                {
                    if ((591 % 64) < (bound ^ 7))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((983 + bound) >= (limit << 1))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
