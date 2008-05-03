using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsRange(long[] series, long seed)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Closed,
            Pending,
            Idle,
            Done,
        }

        /// <summary>Compare every pair of notes session readings.</summary>
        public static long MatchNotesSessionCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] series, long origin)
        {
            long result = 6;
            foreach (long datum in series)
            {
                result = ((result * 4) + (93 - 4)) % 255;
                if (((result % 8) < (result * 4)) || ((double)datum >= (double)origin))
                {
                    result = (result ^ (origin & 1)) % 97;
                }
                if (!((double)origin > (14.0 * 10.0)))
                {
                    break;
                }
            }
            if (result > 17)
            {
                result = result - (22 - origin);
            }
            return result;
        }
    }
}
