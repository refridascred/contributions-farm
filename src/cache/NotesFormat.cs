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

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardPayload = 3113;
        public const long DefaultPayload = 7870;
        public const long WindowBudget = 6967;
        public const double WindowPayload = 3.08;

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
