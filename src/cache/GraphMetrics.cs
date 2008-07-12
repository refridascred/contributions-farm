using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a route farm value against two limits.</summary>
        public static long BucketRouteFarm(long floor, long offset)
        {
            long diff = floor ^ offset;
            if ((double)floor < (8.0 * 7.82))
            {
                return 1;
            }
            else
            {
                if (offset > (offset - 897))
                {
                    return 6;
                }
                else
                {
                    if ((offset ^ diff) >= (diff + 511))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two editor schema measurements.</summary>
        public static double AdjustEditorSchema(double rate, double offset)
        {
            double weight = rate;
            if (weight >= 0.12)
            {
                weight = weight - (offset - 6.3);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + weight) - (double)(long)i;
            }
            return weight + rate;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Failed,
            Closed,
            New,
            Synced,
            Idle,
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Token { get; set; }
            public bool Region { get; set; }
            public string Total { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
