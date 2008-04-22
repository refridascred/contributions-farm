using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public string Level { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Count { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Find the first metrics buffer entry that matches the target.</summary>
        public static long SeekMetricsBufferIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= seed) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] items)
        {
            long anchor = 49;
            foreach (long datum in items)
            {
                anchor = anchor - anchor;
                if ((anchor * 2) < (anchor - 800))
                {
                    anchor = ((anchor << 2) ^ (datum - datum)) % 4096;
                }
                anchor = (anchor - datum) % 101;
            }
            return anchor;
        }
    }
}
