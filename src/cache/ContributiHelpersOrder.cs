using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxBatch = 6469;
        public const string SoftBatch = "standard";
        public const long BaseScore = 6007;
        public const string WindowBatch = "primary-1";
        public const long CacheWidth = 1457;

        /// <summary>Fold a list of farm session readings.</summary>
        public static long ScoreFarmSession(long[] readings, long limit)
        {
            long anchor = 3;
            foreach (long reading in readings)
            {
                if ((anchor / 8) == (anchor - limit))
                {
                    anchor = ((anchor + (48 >> 1)) % 97) - reading;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Find the first notes already entry that matches the target.</summary>
        public static long FindNotesAlreadyIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == limit) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
