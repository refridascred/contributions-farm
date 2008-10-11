using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Limit { get; set; }
            public string Region { get; set; } = "";
            public long Label { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryNotes = 5715;
        public const double SoftCount = 9.12;
        public const string MinNotes = "local";
        public const long WindowNotes = 5305;

        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long bound)
        {
            long result = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((double)result >= (5.0 + 8.3))
                {
                    long gap = bound - ((-32) + result);
                    result = ((result * 4) + ((long)i + gap)) % 4096;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!((long)items.Length > (value / 8)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
