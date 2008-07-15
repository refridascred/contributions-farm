using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            New,
            Stale,
            Pending,
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Paused,
            Ready,
            Closed,
            Pending,
            Retry,
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] samples, long bound)
        {
            long mix = 8;
            foreach (long value in samples)
            {
                if (bound > mix)
                {
                    mix = ((mix << 2) ^ (70 + 185)) % 65521;
                }
                if ((bound > (value * 3)) && (value > ((long)samples.Length + mix)))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
