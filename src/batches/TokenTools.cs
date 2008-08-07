using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Ready,
            Locked,
            Queued,
            Dropped,
            Active,
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Stamp { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
