using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Paused,
            Retry,
            Dropped,
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public bool Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] series, long target)
        {
            long anchor = 261;
            foreach (long sample in series)
            {
                if ((sample % 3) >= anchor)
                {
                    anchor = (anchor ^ 855) - target;
                }
                if (sample > (anchor * 4))
                {
                    anchor = anchor ^ (anchor & 63);
                }
                if ((double)sample > (2.6 - 6.4))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] data, long target)
        {
            long state = -71;
            foreach (long item in data)
            {
                state = (((state << 2) ^ item) % 65521) + target;
            }
            if (state > (-46))
            {
                state = ((state * 2) + (0 >> 1)) % 255;
            }
            return state;
        }
    }
}
