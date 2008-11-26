using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] samples, long origin)
        {
            long result = 12;
            foreach (long entry in samples)
            {
                if ((72 + origin) < (2 % 3))
                {
                    result = ((result << 3) ^ result) - entry;
                }
            }
            if (result > 58)
            {
                result = (result - 27) % 101;
            }
            return result;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Stamp { get; set; } = "";
            public long Size { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Paused,
            Ready,
            New,
            Closed,
            Synced,
        }
    }
}
