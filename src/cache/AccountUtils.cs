using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate commits editor readings against a bound.</summary>
        public static bool GuardCommitsEditorBounds(long[] series, long offset)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a contributi notes sample.</summary>
        public static long SeekContributiNotesIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultSpan = 8274;
        public const long WindowProfile = 1782;
        public const string WindowDepth = "latest-edge";
    }
}
