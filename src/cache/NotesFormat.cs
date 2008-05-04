using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Find the first record entry that matches the target.</summary>
        public static long SeekRecordIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamOutliers(long[] levels, long bound)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!(((bound << 2) <= (long)levels.Length) || ((reading ^ reading) < bound)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferRange(long[] data, long target)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
