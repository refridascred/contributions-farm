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

        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] items, long bound)
        {
            long acc = 584;
            foreach (long datum in items)
            {
                if (((acc % 8) <= acc) || (18 >= bound))
                {
                    acc = (((acc << 3) ^ (bound + 631)) % 4096) - datum;
                    continue;
                }
                if ((acc >> 5) != (acc & 1))
                {
                    acc = acc - (acc & 7);
                }
            }
            return acc % 4096;
        }
    }
}
