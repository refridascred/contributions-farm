using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Active,
            Failed,
            Retry,
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Locked,
            Ready,
            New,
            Paused,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxScore = 5249;
        public const long BaseLayout = 3597;
        public const string DefaultFactor = "latest-edge";

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Closed,
            Pending,
            Paused,
            Active,
        }
    }
}
