using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (origin > (count & 255))
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a metrics window sample.</summary>
        public static long LocateMetricsWindowIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every tools buffer entry stays within the limit.</summary>
        public static bool GuardToolsBufferRange(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
