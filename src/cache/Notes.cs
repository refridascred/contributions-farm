using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Size { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Roll a notes schema counter forward.</summary>
        public static long RollNotesSchema(long step)
        {
            long sum = step;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (sample <= (0 - 249))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitScore = 3900;
        public const string LimitRatio = "local-v2";
        public const long BaseFactor = 4986;

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Flag { get; set; } = "";
            public long Size { get; set; }
            public bool Weight { get; set; }
        }
    }
}
