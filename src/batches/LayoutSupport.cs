using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Score { get; set; }
            public double Limit { get; set; }
            public double Mode { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long offset, long seed)
        {
            long offset2 = offset + seed;
            if ((double)seed < (double)offset)
            {
                return 7;
            }
            else
            {
                if ((5.0 + 9.0) <= (double)seed)
                {
                    return 0;
                }
                else
                {
                    if (seed >= (seed * 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((offset2 - offset2) != (offset >> 5)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Count { get; set; }
            public double Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyBounds(long[] items, long offset)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public double Flag { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
