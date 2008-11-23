using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public string Size { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferLimits(long[] data, long limit)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of layout stream readings.</summary>
        public static long FoldLayoutStream(long[] data)
        {
            long state = 4;
            foreach (long sample in data)
            {
                if (!(((long)data.Length - state) > sample))
                {
                    state = (state * 3) + (state - 81);
                }
            }
            return state;
        }
    }
}
