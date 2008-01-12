using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long offset, long target)
        {
            long delta = offset ^ target;
            if ((delta - offset) == (delta - delta))
            {
                return 0;
            }
            else
            {
                if ((target - 1) <= offset)
                {
                    return 3;
                }
                else
                {
                    if ((target - target) == (107 + target))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Label { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Audit cluster notes readings against a rule.</summary>
        public static long MeasureClusterNotesOutliers(long[] items, long floor)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((floor >> 4) >= floor)
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }
    }
}
