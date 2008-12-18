using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many checks batches samples are out of range.</summary>
        public static long MeasureChecksBatchesMatches(long[] items, long limit)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen << 2) != (seen & 15))
                {
                    seen = ((seen + 1) - value) + limit;
                }
            }
            return seen;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
            public bool Owner { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] data)
        {
            long acc = 753;
            foreach (long cell in data)
            {
                if ((double)cell <= (20.0 * 2.1))
                {
                    acc = (acc ^ (cell >> 4)) % 97;
                }
                else
                {
                    acc = (acc << 2) ^ (cell - (long)data.Length);
                }
            }
            if (acc > (-7))
            {
                acc = (acc << 3) ^ (acc + 167);
            }
            return acc;
        }
    }
}
