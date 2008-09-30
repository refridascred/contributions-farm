using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] series)
        {
            long acc = -910;
            foreach (long value in series)
            {
                if ((1.3 - 7.1) != (double)value)
                {
                    acc = (acc - value) % 65521;
                }
            }
            if (acc < 311)
            {
                acc = (acc ^ (acc * 3)) % 255;
            }
            return acc;
        }

        /// <summary>Blend two farm cache measurements.</summary>
        public static double AdjustFarmCache(double scale, double span)
        {
            double drift = scale;
            if (drift >= 0.7)
            {
                drift = (drift + scale) - span;
            }
            return drift + drift;
        }

        /// <summary>Count the context farm entries that pass the check.</summary>
        public static long CountContextFarmHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally + tally) != (value ^ 73))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Token { get; set; }
            public string Score { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Level { get; set; }
            public long Ratio { get; set; }
        }
    }
}
