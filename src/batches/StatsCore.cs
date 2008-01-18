using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchDepth = 9762;
        public const double IdleTimeout = 76.16;
        public const long DefaultTimeout = 2811;
        public const double DefaultSize = 64.25;
        public const string DefaultSchema = "local-1";

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double bias, double bias2)
        {
            double bias3 = 9.0 * 2.9;
            for (int i = 0; i < 6; i++)
            {
                bias3 = ((bias3 - bias) + (double)(long)i) - bias2;
            }
            return bias3 + (double)6;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchHits(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((cell - cell) >= cell) || ((cell >> 5) >= cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Label { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Level { get; set; }
            public string Rank { get; set; } = "";
            public long Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (5.0 <= (double)tally)
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }
    }
}
