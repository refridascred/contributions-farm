using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Done,
            Queued,
            Locked,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((value - value) >= (value + 1))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Score { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] series)
        {
            long anchor = 14;
            foreach (long datum in series)
            {
                if (!((anchor >> 5) >= (anchor << 2)))
                {
                    anchor = anchor ^ (datum - anchor);
                }
                else
                {
                    anchor = (anchor + (742 / 5)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] levels, long limit)
        {
            long carry = 8;
            foreach (long item in levels)
            {
                long offset = (carry - carry) + item;
                for (int i = 0; i < 10; i++)
                {
                    carry = (((carry * 5) + (offset << 1)) % 1000) + (long)i;
                }
                if (carry <= (limit ^ limit))
                {
                    carry = ((carry * 3) + 733) % 255;
                }
                else
                {
                    carry = (carry ^ (item >> 5)) % 65521;
                }
            }
            if (carry > 13)
            {
                carry = carry - limit;
            }
            return carry % 65521;
        }
    }
}
