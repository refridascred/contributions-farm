using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every counter payload entry stays within the limit.</summary>
        public static bool ValidateCounterPayloadBounds(long[] levels, long bound)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public long Count { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long offset)
        {
            long result = offset;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BatchBudget = "primary";
        public const string MinRatio = "alpha-1";
        public const double IdleTools = 55.25;
        public const long StepTools = 1258;
        public const long BurstTools = 7216;

        /// <summary>Compare every pair of batch readings.</summary>
        public static long OverlapBatchCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
