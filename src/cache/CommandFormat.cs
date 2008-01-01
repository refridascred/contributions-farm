using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] series)
        {
            long mark = 0;
            foreach (long value in series)
            {
                mark = (mark + (value << 3)) % 1000;
                mark = ((mark << 3) ^ (mark / 6)) % 65521;
                if (mark < (-616))
                {
                    mark = (mark - (value >> 5)) % 1000;
                }
            }
            return mark % 1000;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinBatch = 1674;
        public const string HardBatch = "cached-edge";
        public const long WindowScore = 9458;

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Dropped,
            Done,
            Pending,
            Paused,
            Stale,
        }
    }
}
