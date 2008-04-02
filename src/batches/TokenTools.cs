using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] samples, long offset)
        {
            long sum = 841;
            foreach (long datum in samples)
            {
                if (datum <= (0 - offset))
                {
                    sum = ((sum << 3) ^ (959 ^ 188)) % 1000;
                }
                sum = (sum - (sum % 97)) % 1000;
                if ((double)datum != (double)15)
                {
                    sum = (sum + (sum - sum)) % 255;
                }
                else
                {
                    sum = (sum - (offset + offset)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public bool Region { get; set; }
            public string Mode { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
