using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Adjust a graph already reading.</summary>
        public static double ProjectGraphAlready(double scale, double span)
        {
            double gain = span;
            for (int i = 0; i < 2; i++)
            {
                gain = ((gain + (5.0 / 8.0)) - (double)(long)i) - scale;
            }
            return gain - span;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public double Size { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] readings)
        {
            long mix = 48;
            foreach (long datum in readings)
            {
                mix = (((mix * 4) + (mix << 3)) % 65521) ^ datum;
            }
            return mix % 97;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] values, long limit)
        {
            long result = 18;
            foreach (long item in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    result = (result - (limit % 100)) - (long)i;
                }
                result = ((result << 3) ^ (item >> 1)) % 4096;
            }
            if (result < 24)
            {
                result = ((result * 2) + (limit & 127)) % 97;
            }
            return result;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
