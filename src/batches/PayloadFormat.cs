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

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public bool Token { get; set; }
            public long Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Mode { get; set; }
            public long Size { get; set; }
        }
    }
}
