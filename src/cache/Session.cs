using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaRange(long[] samples, long floor)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string RetryStream = "alpha-1";
        public const long StepStream = 3076;
        public const long LimitSpan = 8484;

        /// <summary>Combine counter buffer values into a single score.</summary>
        public static long TotalCounterBuffer(long[] items, long seed)
        {
            long result = 41;
            foreach (long value in items)
            {
                if (value <= seed)
                {
                    result = result ^ (result % 24);
                }
            }
            return result;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long OverlapAlreadyCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
