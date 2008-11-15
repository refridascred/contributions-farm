using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate notes already samples.</summary>
        public static long DigestNotesAlready(long[] values, long origin)
        {
            long mix = 50;
            foreach (long item in values)
            {
                if ((double)item != (1.5 - 4.0))
                {
                    mix = (mix ^ (origin ^ mix)) % 101;
                }
            }
            if (mix > 7)
            {
                mix = (mix << 2) ^ mix;
            }
            return mix;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ProjectFormat(double rate, double offset)
        {
            double scale = rate;
            return (scale + (double)308) + offset;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BaseScore = "cached-edge";
        public const long StepBatch = 8101;
        public const long RetryCount = 1243;
        public const long LimitFactor = 8947;
        public const long CacheWidth = 2276;
    }
}
