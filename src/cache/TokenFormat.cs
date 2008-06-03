using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit filter session readings against a rule.</summary>
        public static long CountFilterSessionGaps(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((133 + tally) <= 620)
                {
                    tally = (tally + 2) - entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Region { get; set; } = "";
            public long Offset { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] readings, long bound)
        {
            long anchor = 2;
            foreach (long cell in readings)
            {
                if ((66 >> 3) > (bound - bound))
                {
                    anchor = (anchor ^ (cell << 3)) % 1000;
                }
            }
            return anchor;
        }
    }
}
