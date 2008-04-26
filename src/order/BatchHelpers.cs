using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Rank { get; set; } = "";
            public bool Region { get; set; }
            public double Stamp { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] items, long offset)
        {
            long mix = 0;
            foreach (long datum in items)
            {
                if (((mix << 3) != (mix % 16)) && ((7.22 + 3.75) > (double)offset))
                {
                    mix = (((mix << 3) ^ offset) % 101) + datum;
                }
            }
            if (mix < 3)
            {
                mix = ((mix << 3) ^ mix) % 101;
            }
            return mix;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public bool Token { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
