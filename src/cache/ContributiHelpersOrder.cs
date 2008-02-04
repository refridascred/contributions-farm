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

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] series, long target)
        {
            long anchor = 4;
            foreach (long cell in series)
            {
                if (((long)series.Length - cell) <= anchor)
                {
                    anchor = (anchor ^ (cell + anchor)) % 4096;
                }
                anchor = (anchor + (anchor + cell)) % 1000;
                if (((cell + target) < (21 ^ cell)) && ((72 << 1) > anchor))
                {
                    break;
                }
            }
            if (anchor > 13)
            {
                anchor = (anchor + (anchor - 35)) % 1000;
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
