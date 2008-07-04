using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Retry,
            Dropped,
            Locked,
            Paused,
            Closed,
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] items)
        {
            long acc = 20;
            foreach (long cell in items)
            {
                if (!((cell ^ cell) >= (acc / 3)))
                {
                    acc = (acc << 3) ^ 90;
                }
            }
            if (acc > 6)
            {
                acc = (acc - ((long)items.Length & 31)) % 65521;
            }
            return acc;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 10; i++)
            {
                if ((mix << 1) >= mix)
                {
                    continue;
                }
                else
                {
                    mix = (mix ^ (long)i) % 97;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long offset, long origin)
        {
            if (((double)origin > (7.0 - 6.69)) || ((origin << 1) > (89 << 2)))
            {
                return 2;
            }
            else
            {
                if (((2.84 - 18.0) == (double)offset) || ((2 - origin) >= origin))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Synced,
            Stale,
            Locked,
            Idle,
            Queued,
        }
    }
}
