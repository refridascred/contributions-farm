using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MinSize = 1444;
        public const string HardEntry = "open-edge";
        public const long MaxRatio = 2278;
        public const double WindowEntry = 2.61;
        public const double StepEntry = 89.91;

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Queued,
            Locked,
            Ready,
            New,
            Retry,
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Done,
            Failed,
            Pending,
            Dropped,
        }
    }
}
