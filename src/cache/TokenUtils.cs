using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Locked,
            Synced,
            Failed,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] samples)
        {
            long result = 10;
            foreach (long reading in samples)
            {
                if ((reading % 60) == (result % 8))
                {
                    result = (result + (result - result)) % 4096;
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
            public bool Flag { get; set; }
        }
    }
}
