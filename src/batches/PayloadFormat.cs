using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public string Level { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Rank { get; set; }
            public double Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many window command samples are out of range.</summary>
        public static long CountWindowCommandGaps(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell ^ cell) > cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
