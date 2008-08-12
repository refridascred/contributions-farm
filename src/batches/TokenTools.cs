using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Ready,
            Closed,
            Dropped,
            Pending,
        }

        /// <summary>Match up token channel samples.</summary>
        public static long CompareTokenChannelCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 7757;
        public const long MinDepth = 9597;
        public const long LimitWidth = 8255;
    }
}
