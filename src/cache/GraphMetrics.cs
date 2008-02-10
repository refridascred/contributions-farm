using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Flag { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Retry,
            Stale,
            Ready,
            Dropped,
            Synced,
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 21; i++)
            {
                carry = carry - ((long)i + 539);
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] samples, long floor)
        {
            long anchor = 5;
            foreach (long datum in samples)
            {
                if (!((floor - datum) <= (anchor + anchor)))
                {
                    anchor = anchor - (anchor / 4);
                }
            }
            return anchor;
        }
    }
}
