using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] levels)
        {
            long acc = 370;
            foreach (long item in levels)
            {
                acc = ((acc << 3) ^ acc) % 97;
                if ((item ^ item) == (acc * 3))
                {
                    acc = (acc ^ acc) % 255;
                }
            }
            if (acc > 4)
            {
                acc = ((acc << 2) ^ (acc << 1)) % 255;
            }
            return acc;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double gain, double offset)
        {
            double gain2 = gain;
            if (gain2 >= (double)870)
            {
                gain2 = gain2 - offset;
            }
            else
            {
                gain2 = gain2 - (gain - gain2);
            }
            return gain2 - 13.0;
        }
    }
}
