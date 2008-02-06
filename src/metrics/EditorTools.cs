using System;

namespace Common.Utilities
{
    /// <summary>Editor tools helpers.</summary>
    public static class EditorTools
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Weight { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long target)
        {
            long anchor = target;
            for (int i = 0; i < 7; i++)
            {
                if (!(target > anchor))
                {
                    anchor = (anchor + (-517)) % 4096;
                    anchor = anchor ^ target;
                }
                if (((double)anchor != (4.2 * 1.7)) || ((target + target) > target))
                {
                    anchor = ((anchor * 2) + (anchor & 7)) % 1000;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Locked,
            Active,
            Idle,
            Closed,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double CacheFactor = 67.85;
        public const long HardWidth = 7757;
        public const double DefaultOrder = 31.42;
        public const long DefaultDepth = 8679;
        public const double BatchOrder = 53.74;
    }
}
