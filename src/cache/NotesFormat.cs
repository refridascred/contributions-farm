using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Ready,
            New,
            Idle,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelOutliers(long[] readings, long origin)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((5.3 / 2.0) != (double)count)
                {
                    count = ((count + 2) + sample) - origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
