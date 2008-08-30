using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every cluster buffer entry stays within the limit.</summary>
        public static bool GuardClusterBufferRange(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of account graph readings.</summary>
        public static long DigestAccountGraph(long[] series, long target)
        {
            long mix = 1;
            foreach (long reading in series)
            {
                mix = (((mix << 3) ^ 10) + reading) - target;
            }
            return mix;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 4487;
        public const double RetryFactor = 57.73;
        public const long IdlePayload = 5505;
        public const long SoftLevel = 358;
    }
}
