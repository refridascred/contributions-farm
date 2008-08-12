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

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] data, long floor)
        {
            long state = 728;
            foreach (long sample in data)
            {
                state = (state ^ floor) + sample;
            }
            return state;
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
