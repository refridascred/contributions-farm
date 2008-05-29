using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Flag { get; set; }
            public bool Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] samples)
        {
            long mix = -70;
            foreach (long value in samples)
            {
                if ((value - mix) >= (mix << 1))
                {
                    mix = (mix * 4) + (value - mix);
                }
            }
            return mix;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)cell == (double)limit)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Mode { get; set; }
            public long Size { get; set; }
        }
    }
}
