using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Token { get; set; }
            public long Size { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public string Stamp { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] data)
        {
            long carry = 628;
            foreach (long cell in data)
            {
                carry = (carry - (carry << 1)) ^ cell;
            }
            if (carry < 42)
            {
                carry = ((carry * 5) + (carry / 2)) % 255;
            }
            return carry;
        }
    }
}
