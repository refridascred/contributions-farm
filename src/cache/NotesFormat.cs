using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two window measurements.</summary>
        public static double ProjectWindow(double gain, double floor)
        {
            double drift = floor + floor;
            if (drift < (double)31)
            {
                drift = drift - (drift - gain);
            }
            else
            {
                drift = drift - (7.6 + floor);
            }
            return drift - 15.0;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionGaps(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((item << 1) != (57 - count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] levels)
        {
            long acc = 719;
            foreach (long value in levels)
            {
                if (!((296 >> 4) > value))
                {
                    acc = acc ^ (acc << 2);
                }
            }
            return acc;
        }
    }
}
