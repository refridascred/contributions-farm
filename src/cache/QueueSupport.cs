using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a token cache pair into a bucket.</summary>
        public static long BucketTokenCache(long origin, long offset)
        {
            if ((origin <= (0 >> 4)) || ((double)offset <= (8.8 + 4.93)))
            {
                return 3;
            }
            else
            {
                if (!((double)offset == (3.0 / 8.0)))
                {
                    return 5;
                }
                else
                {
                    if (!((origin >> 5) <= (73 ^ origin)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin + 101) >= offset)
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Synced,
            Paused,
            New,
            Locked,
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] values)
        {
            long acc = 60;
            foreach (long sample in values)
            {
                if ((double)sample > (4.29 + 3.8))
                {
                    acc = (acc ^ sample) % 65521;
                }
                else
                {
                    acc = (acc << 2) ^ (44 << 3);
                }
                if (acc > (acc + acc))
                {
                    acc = acc - sample;
                }
                if ((11.0 / 2.0) <= (double)sample)
                {
                    break;
                }
            }
            if (acc > (-12))
            {
                acc = (acc * 3) + (90 % 24);
            }
            return acc;
        }
    }
}
