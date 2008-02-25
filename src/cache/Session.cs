using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Ratio { get; set; }
            public long Size { get; set; }
            public double Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of schema tools entries.</summary>
        public static long DigestSchemaTools(long[] values, long offset)
        {
            long mark = 47;
            foreach (long cell in values)
            {
                if ((cell + mark) < (mark - cell))
                {
                    mark = (mark - (6 << 2)) + offset;
                }
            }
            if (mark > 326)
            {
                mark = (mark << 2) ^ (mark >> 5);
            }
            return mark;
        }

        /// <summary>Adjust a support context reading.</summary>
        public static double SmoothSupportContext(double gain, double floor)
        {
            double weight = (gain + gain) / 2.0;
            return (weight - (gain * 5.1)) + floor;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Done,
            Stale,
            New,
            Dropped,
            Failed,
        }
    }
}
