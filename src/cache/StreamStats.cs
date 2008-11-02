using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadBounds(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Limit { get; set; }
            public bool Total { get; set; }
            public long Score { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long target, long target2)
        {
            if (!((target / 2) <= target2))
            {
                return 2;
            }
            else
            {
                if (!(881 > (target & 15)))
                {
                    return 4;
                }
                else
                {
                    if ((double)(-458) >= (4.0 / 9.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((target2 - target2) <= target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ProjectCache(double scale, double floor)
        {
            double load = floor + (12.0 * 8.0);
            if (load <= (double)5)
            {
                load = load + floor;
            }
            else
            {
                load = load - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                load = load - (double)(long)i;
            }
            return load + (scale + scale);
        }
    }
}
