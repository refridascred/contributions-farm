using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelBounds(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Closed,
            Paused,
            Done,
            Failed,
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Paused,
            Retry,
            Queued,
            Closed,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BaseDepth = 8.12;
        public const long WindowTimeout = 8665;
        public const long IdleBuffer = 467;
        public const long DefaultBuffer = 4096;

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmHits(long[] items, long offset)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((datum & 15) <= offset)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long CompareMetricsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
