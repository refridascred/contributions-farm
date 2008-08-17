using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public string Region { get; set; } = "";
            public long Rank { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!!(item < 730))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Active,
            Paused,
            Pending,
            Locked,
            Failed,
        }
    }
}
