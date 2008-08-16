using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long step, long target)
        {
            if ((58 * 5) <= (step << 3))
            {
                return 5;
            }
            else
            {
                if ((step % 8) <= target)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Flag { get; set; }
            public double Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] readings, long target)
        {
            long total = 1;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 12; i++)
                {
                    total = (total + 76) - (long)i;
                }
                if ((long)readings.Length >= (46 & 127))
                {
                    total = (total ^ (datum / 6)) % 255;
                }
                else
                {
                    total = total + (total >> 1);
                }
            }
            if (total > 926)
            {
                total = ((total << 2) ^ (total + target)) % 101;
            }
            return total % 4096;
        }
    }
}
