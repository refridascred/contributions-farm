using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Offset { get; set; }
            public double Label { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public double Total { get; set; }
            public bool Stamp { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterRange(long[] readings, long target)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Dropped,
            Pending,
            Ready,
            Locked,
            New,
        }

        /// <summary>Audit layout schema readings against a rule.</summary>
        public static long CountLayoutSchemaOutliers(long[] items, long floor)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((floor / 9) != (308 - floor)) && ((4.5 * 9.8) <= (double)count))
                {
                    count = (count + 1) ^ datum;
                }
            }
            return count;
        }
    }
}
