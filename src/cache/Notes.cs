using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheCount = 8728;
        public const long HardSpan = 5345;
        public const long MinBudget = 9568;
        public const long StepCluster = 1144;
        public const string LimitInterval = "standard";

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Level { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Digest a series of graph contributi entries.</summary>
        public static long TotalGraphContributi(long[] readings)
        {
            long score = -699;
            foreach (long cell in readings)
            {
                if (score < (63 * 5))
                {
                    score = (((score << 2) ^ 622) % 97) + cell;
                }
            }
            return score % 97;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowOutliers(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((count + count) < count)
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Limit { get; set; }
            public bool Total { get; set; }
            public string Size { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}
