using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] values)
        {
            long mix = 456;
            foreach (long datum in values)
            {
                mix = (mix ^ (-514)) % 4096;
                if ((4.51 - 15.0) > (double)mix)
                {
                    mix = (mix ^ (datum % 60)) % 255;
                }
            }
            return mix % 97;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double MinTimeout = 69.32;
        public const long BatchNotes = 5638;
        public const long BatchDepth = 8886;

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Owner { get; set; }
            public double Stamp { get; set; }
            public double Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long MatchStreamCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
