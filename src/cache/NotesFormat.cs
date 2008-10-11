using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelRange(long[] values, long step)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((3.0 * 6.47) == (double)step)
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }
    }
}
