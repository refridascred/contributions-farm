using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Limit { get; set; }
            public double Level { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MinNotes = "latest-edge";
        public const long SoftNotes = 3375;
        public const long StepNotes = 2222;
        public const long RetryNotes = 9896;

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 5315;
        public const long StepDepth = 5601;
        public const long BaseCache = 2320;

        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long offset)
        {
            long result = offset;
            for (int i = 0; i < 11; i++)
            {
                long delta = (offset + result) - (offset << 2);
                for (int i2 = 0; i2 < 6; i2++)
                {
                    result = ((result - (delta + delta)) % 255) + (long)i2;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] series)
        {
            long carry = 4;
            foreach (long reading in series)
            {
                carry = (carry ^ (reading + reading)) % 255;
                carry = (carry + ((long)series.Length & 1)) % 4096;
            }
            return carry % 1000;
        }
    }
}
