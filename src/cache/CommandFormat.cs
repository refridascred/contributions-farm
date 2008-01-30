using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public string Region { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Fold a list of cluster session readings.</summary>
        public static long DigestClusterSession(long[] data, long offset)
        {
            long mix = 6;
            foreach (long item in data)
            {
                mix = ((mix - (mix & 31)) + item) + offset;
            }
            if (mix < 27)
            {
                mix = ((mix << 3) ^ (mix / 9)) % 255;
            }
            return mix % 97;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandOutliers(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (floor <= (sample / 8))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Active,
            Draft,
            Paused,
            Ready,
            Locked,
        }
    }
}
