using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the command graph entries that pass the check.</summary>
        public static long CountCommandGraphHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((long)values.Length > datum)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BaseLevel = "stable-edge";
        public const long MaxLevel = 7420;
        public const double BatchFactor = 17.26;

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Token { get; set; }
            public double Level { get; set; }
            public long Ratio { get; set; }
        }
    }
}
