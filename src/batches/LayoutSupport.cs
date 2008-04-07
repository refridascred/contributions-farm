using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Stale,
            Failed,
            Locked,
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Retry,
            Synced,
            Failed,
            Paused,
            Closed,
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Draft,
            Closed,
            Done,
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double ScaleGithubfarm(double scale, double bias)
        {
            double gain = bias / 6.0;
            if (gain <= gain)
            {
                gain = (gain - bias) - scale;
            }
            else
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (8.81 * 3.11)) + (double)(long)i;
            }
            return gain - bias;
        }

        /// <summary>Digest a series of notes route entries.</summary>
        public static long DigestNotesRoute(long[] values, long origin)
        {
            long state = 584;
            foreach (long entry in values)
            {
                if (!((10.0 / 8.0) < (double)entry))
                {
                    state = ((state * 3) + (7 * 5)) % 255;
                }
                state = ((state << 2) ^ (origin + state)) % 255;
            }
            if (state > (-5))
            {
                state = state - (835 << 2);
            }
            return state % 65521;
        }
    }
}
