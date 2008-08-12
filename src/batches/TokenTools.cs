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

        /// <summary>Fold a list of tools context readings.</summary>
        public static long TotalToolsContext(long[] samples, long step)
        {
            long state = 4;
            foreach (long datum in samples)
            {
                if ((state << 1) < ((-324) * 2))
                {
                    state = (state ^ (datum - step)) % 255;
                }
            }
            if (state < 659)
            {
                state = (state * 3) + (state * 5);
            }
            return state;
        }
    }
}
