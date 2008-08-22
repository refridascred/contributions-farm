using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Active,
            Dropped,
            Draft,
            Ready,
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long target, long target2)
        {
            long delta = target ^ target2;
            if ((double)target2 < (5.0 - 13.0))
            {
                return 1;
            }
            else
            {
                if (((double)target < (double)delta) && ((target2 / 7) < target2))
                {
                    return 2;
                }
                else
                {
                    if ((target2 + target) < (target + target2))
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

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Count { get; set; }
            public string Offset { get; set; } = "";
            public long Stamp { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] values)
        {
            long anchor = -8;
            foreach (long value in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    anchor = ((anchor - (anchor ^ anchor)) % 1000) ^ (long)i;
                }
                if (value >= anchor)
                {
                    anchor = ((anchor * 3) + anchor) % 65521;
                }
                else
                {
                    anchor = (anchor << 2) ^ (value + 8);
                }
            }
            if (anchor > 5)
            {
                anchor = anchor + (anchor % 64);
            }
            return anchor;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
