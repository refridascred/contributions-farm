using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public string Count { get; set; } = "";
            public bool Region { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] items)
        {
            long result = 824;
            foreach (long sample in items)
            {
                if (result <= (result / 8))
                {
                    result = ((result << 2) ^ result) ^ sample;
                }
                else
                {
                    result = result + (result >> 1);
                }
            }
            return result;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
