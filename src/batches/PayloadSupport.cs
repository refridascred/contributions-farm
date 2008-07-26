using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordHits(long[] values, long origin)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count & 255) == (datum ^ (long)values.Length))
                {
                    count = (count + 1) - origin;
                }
            }
            return count;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] levels, long bound)
        {
            long acc = 3;
            foreach (long datum in levels)
            {
                if (!(datum <= (acc >> 5)))
                {
                    acc = (acc << 2) ^ (bound ^ acc);
                }
            }
            return acc;
        }
    }
}
