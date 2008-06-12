using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double rate, double floor)
        {
            double weight = floor;
            if (weight >= floor)
            {
                weight = weight + (double)68;
            }
            else
            {
                weight = weight - (weight + rate);
            }
            return weight + 2.0;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatMatches(long[] values, long floor)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (!(((count % 97) > count) || ((double)cell > 2.0)))
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteOutliers(long[] items, long bound)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((bound + matches) < (matches + entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Flag { get; set; }
            public string Level { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
