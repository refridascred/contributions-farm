using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Paused,
            Pending,
            New,
            Active,
            Done,
        }

        /// <summary>Look up the position of a session notes sample.</summary>
        public static long SeekSessionNotesIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
