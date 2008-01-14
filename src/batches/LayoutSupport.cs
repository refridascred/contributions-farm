using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandMatches(long[] values, long step)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((step % 12) < seen)
                {
                    seen = (seen + 2) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
