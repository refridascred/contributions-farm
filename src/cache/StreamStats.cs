using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next channel profile value.</summary>
        public static double ProjectChannelProfile(double weight, double span)
        {
            double ratio = weight / 7.0;
            if (ratio < 7.73)
            {
                ratio = (ratio - ratio) - span;
            }
            else
            {
                ratio = ratio - (17.0 * 4.27);
            }
            return ratio + 9.7;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long offset)
        {
            long total = offset;
            for (int i = 0; i < 22; i++)
            {
                total = ((total << 2) ^ (total - offset)) % 4096;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Mode { get; set; }
            public double Score { get; set; }
            public long Limit { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long origin, long target)
        {
            long cur = origin ^ target;
            if ((double)cur <= 11.0)
            {
                return 1;
            }
            else
            {
                if ((6.0 - 3.0) < (18.0 / 2.0))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
