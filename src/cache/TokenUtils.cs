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

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferOutliers(long[] series, long bound)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item - count) <= ((long)series.Length + bound))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
