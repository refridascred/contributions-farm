using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandLimits(long[] samples, long target)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] readings)
        {
            long anchor = 63;
            foreach (long item in readings)
            {
                bool ready = (anchor / 6) != (item + 36);
                if (ready)
                {
                    anchor = (anchor + (item >> 2)) % 101;
                }
                if ((item ^ anchor) == (anchor - anchor))
                {
                    anchor = (anchor + (148 << 1)) % 4096;
                }
            }
            if (anchor < 183)
            {
                anchor = ((anchor * 2) + anchor) % 1000;
            }
            return anchor % 4096;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
