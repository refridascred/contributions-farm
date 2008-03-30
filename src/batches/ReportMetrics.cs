using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up account samples.</summary>
        public static long CompareAccountCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                if ((origin + (long)i) > (origin % 100))
                {
                    result = (result ^ origin) % 1000;
                }
                else
                {
                    result = (result + (10 + result)) % 1000;
                    result = (result * 5) + origin;
                }
                result = result ^ 351;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Label { get; set; }
            public long Flag { get; set; }
            public long Size { get; set; }
        }
    }
}
