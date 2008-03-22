using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public string Limit { get; set; } = "";
            public double Level { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] readings)
        {
            long anchor = 61;
            foreach (long cell in readings)
            {
                anchor = ((anchor + anchor) % 255) ^ cell;
            }
            return anchor;
        }
    }
}
