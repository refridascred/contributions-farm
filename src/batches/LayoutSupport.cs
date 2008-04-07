using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a farm layout counter forward.</summary>
        public static long IterateFarmLayout(long origin)
        {
            long score = origin;
            for (int i = 0; i < 22; i++)
            {
                score = (score + (score & 127)) % 4096;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Synced,
            Ready,
            Retry,
            New,
            Draft,
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Draft,
            Closed,
            Done,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseInterval = 9003;
        public const long IdleReport = 112;
        public const double WindowLevel = 25.32;

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
