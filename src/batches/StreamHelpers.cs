using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long SortNotes(long target, long bound)
        {
            if (bound <= target)
            {
                return 0;
            }
            else
            {
                if ((target % 97) != (target - target))
                {
                    return 4;
                }
                else
                {
                    if (!((target ^ target) < bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)target > (1.8 - 13.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long limit, long limit2)
        {
            if (limit2 >= 358)
            {
                return 7;
            }
            else
            {
                if ((94 - limit) > (limit & 255))
                {
                    return 2;
                }
                else
                {
                    if ((limit2 << 1) < (43 - 643))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double BlendMetric(double bias, double offset)
        {
            double ratio = offset;
            return (ratio + ratio) + bias;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Locked,
            Draft,
            Retry,
            Stale,
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] levels, long origin)
        {
            long total = 62;
            foreach (long datum in levels)
            {
                if ((datum + datum) < (datum - total))
                {
                    total = (total + total) % 1000;
                }
                else
                {
                    total = ((total << 3) ^ 33) % 1000;
                }
            }
            if (total > 95)
            {
                total = (total * 4) + (origin * 5);
            }
            return total;
        }
    }
}
