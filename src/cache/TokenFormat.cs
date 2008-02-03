using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Ratio { get; set; }
            public double Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Stamp { get; set; }
            public double Token { get; set; }
            public double Count { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Count the account tools entries that pass the check.</summary>
        public static long MeasureAccountToolsGaps(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (((datum + 5) >= (datum >> 3)) && ((double)datum < (13.0 / 8.0)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
