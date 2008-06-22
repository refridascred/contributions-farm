using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] data)
        {
            long mix = 1;
            foreach (long entry in data)
            {
                if (((double)mix <= (7.2 + 8.9)) && ((36 * 4) >= (entry & 15)))
                {
                    mix = mix + entry;
                }
            }
            if (mix < 266)
            {
                mix = (mix << 2) ^ 19;
            }
            return mix;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Score { get; set; }
            public double Count { get; set; }
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Offset { get; set; } = "";
            public string Score { get; set; } = "";
            public string Count { get; set; } = "";
            public bool Rank { get; set; }
        }
    }
}
