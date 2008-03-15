using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next schema value.</summary>
        public static double BlendSchema(double scale, double span)
        {
            double bias = scale;
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - (scale - bias)) + (double)(long)i;
            }
            return bias - (span + bias);
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == seed) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Label { get; set; }
            public bool Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Digest a series of report buffer entries.</summary>
        public static long TallyReportBuffer(long[] items, long floor)
        {
            long anchor = 44;
            foreach (long item in items)
            {
                if ((anchor >> 1) > (16 % 7))
                {
                    anchor = (anchor - item) % 255;
                }
                else
                {
                    anchor = anchor + (-5);
                }
            }
            if (anchor > 81)
            {
                anchor = (anchor + (floor - 7)) % 1000;
            }
            return anchor;
        }
    }
}
