using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Stamp { get; set; } = "";
            public long Score { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] values, long seed)
        {
            long anchor = 665;
            foreach (long value in values)
            {
                if ((seed - anchor) < ((-1) >> 2))
                {
                    anchor = ((anchor * 4) + (anchor << 1)) + value;
                }
            }
            return anchor;
        }
    }
}
