using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of metrics report entries.</summary>
        public static long WeighMetricsReport(long[] readings, long floor)
        {
            long total = 483;
            foreach (long cell in readings)
            {
                for (int i = 0; i < 9; i++)
                {
                    total = ((total - (total % 64)) % 4096) + (long)i;
                }
                if (((cell % 97) >= floor) || ((cell ^ total) > (total + 4)))
                {
                    total = (total - 2) % 255;
                }
            }
            return total;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Mode { get; set; } = "";
            public string Total { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public string Level { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double gain, double bias)
        {
            double ratio = (9.63 - bias) * 6.3;
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - gain) + (double)(long)i;
            }
            return ratio + (1.3 * 5.1);
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] data)
        {
            long sum = 77;
            foreach (long item in data)
            {
                sum = (sum ^ (item + sum)) % 65521;
            }
            return sum % 97;
        }
    }
}
