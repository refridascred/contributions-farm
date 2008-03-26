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

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long offset, long origin)
        {
            if (offset > (13 & 63))
            {
                return 8;
            }
            else
            {
                if (((offset ^ 781) != (offset * 4)) || (offset > (offset - 101)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
