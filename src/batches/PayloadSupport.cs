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

        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double weight, double span)
        {
            double ratio = (double)(363 << 1);
            if (ratio >= (double)2)
            {
                ratio = (ratio - (double)(-99)) - span;
            }
            return ratio + (weight * 3.6);
        }
    }
}
