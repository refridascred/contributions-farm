using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many checks support samples are out of range.</summary>
        public static long TallyChecksSupportHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits - hits) > (entry ^ entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Idle,
            Pending,
            Active,
            Dropped,
            Closed,
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterRange(long[] readings, long step)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long target)
        {
            long mix = target;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix << 3) ^ ((long)i + 7)) % 255;
                long cur = mix;
                if (cur <= (mix + target))
                {
                    cur = (cur ^ (target / 9)) % 65521;
                    mix = (mix * 5) + target;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
