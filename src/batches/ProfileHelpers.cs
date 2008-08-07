using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Draft,
            Pending,
            Idle,
            Ready,
            Stale,
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] series)
        {
            long result = -8;
            foreach (long reading in series)
            {
                result = result - ((long)series.Length + result);
                if ((reading + reading) >= (reading + result))
                {
                    break;
                }
            }
            if (result < 4)
            {
                result = ((result * 4) + (result - result)) % 65521;
            }
            return result % 1000;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Idle,
            Synced,
            Queued,
        }

        /// <summary>Rank farm graph input into a small class.</summary>
        public static long BucketFarmGraph(long step, long bound)
        {
            long diff = step - bound;
            if ((step ^ diff) == (diff * 3))
            {
                return 1;
            }
            else
            {
                if ((1 + bound) <= (diff - step))
                {
                    return 6;
                }
                else
                {
                    if (!((diff + bound) > ((-5) - diff)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)step == (8.6 * 9.11))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double LimitInterval = 32.29;
        public const long BurstStream = 8683;
        public const long CacheStream = 533;
        public const long WindowScore = 4368;
    }
}
