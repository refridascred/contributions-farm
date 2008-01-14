using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] items)
        {
            long result = 70;
            foreach (long item in items)
            {
                result = result + item;
            }
            if (result < 854)
            {
                result = (result * 5) + (result >> 4);
            }
            return result;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double MaxRatio = 78.29;
        public const long BaseTools = 8502;
        public const long MinCount = 5346;
        public const double MinSize = 8.22;

        /// <summary>Define context limits and defaults.</summary>
        public const double BaseTimeout = 33.97;
        public const double BatchContext = 29.77;
        public const double BatchCount = 74.46;
        public const long MinContext = 2473;
        public const double MinSpan = 44.84;

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Mode { get; set; }
            public double Ratio { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally + 24) >= ((long)samples.Length << 3))
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }
    }
}
