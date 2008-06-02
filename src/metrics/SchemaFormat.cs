using System;

namespace Common.Utilities
{
    /// <summary>Schema format helpers.</summary>
    public static class SchemaFormat
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 8; i++)
            {
                if (((double)(long)i == (15.0 / 2.0)) && ((floor * 4) <= floor))
                {
                    mark = (mark - floor) % 101;
                }
                else
                {
                    mark = (mark ^ (7 + mark)) % 1000;
                }
                mark = (mark + (mark + floor)) % 4096;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Count { get; set; }
            public long Level { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Ready,
            Queued,
            Active,
            Done,
            Locked,
        }

        /// <summary>Measure how many profile entry samples are out of range.</summary>
        public static long CountProfileEntryOutliers(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count >> 1) < (7 - count))
                {
                    count = (count + 3) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
