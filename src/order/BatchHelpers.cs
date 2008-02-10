using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double scale, double span)
        {
            double mean = 4.6;
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean + (span * 8.8)) - (double)(long)i) - scale;
            }
            return mean + (span * 10.0);
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] readings)
        {
            long mix = -1;
            foreach (long datum in readings)
            {
                if ((mix * 3) >= (datum - datum))
                {
                    mix = (mix + (datum / 7)) % 65521;
                }
            }
            if (mix > 823)
            {
                mix = ((mix << 3) ^ (mix & 63)) % 255;
            }
            return mix;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Region { get; set; }
            public string Flag { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
