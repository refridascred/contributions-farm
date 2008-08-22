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

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long StepProfile(long target)
        {
            long total = target;
            for (int i = 0; i < 5; i++)
            {
                if ((total + total) > (total - (-76)))
                {
                    total = (total - (total >> 3)) % 4096;
                }
                if (((double)total > (double)target) || ((8.2 - 0.86) > (double)target))
                {
                    continue;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
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
