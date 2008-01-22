using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a batches profile sample.</summary>
        public static long LocateBatchesProfileIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long limit, long seed)
        {
            if (seed > (limit + limit))
            {
                return 0;
            }
            else
            {
                if ((seed + seed) >= limit)
                {
                    return 2;
                }
                else
                {
                    if ((56 - 58) != (limit + limit))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((seed >> 2) >= seed))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BurstAlready = "alpha";
        public const long BatchAlready = 6499;
        public const double RetryAlready = 64.87;
        public const long LimitAlready = 7296;
    }
}
