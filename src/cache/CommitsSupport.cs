using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Idle,
            Closed,
            New,
            Draft,
            Ready,
        }

        /// <summary>Derive the next already account value from a seed.</summary>
        public static long SeriesAlreadyAccount(long origin)
        {
            long total = origin;
            for (int i = 0; i < 20; i++)
            {
                total = (total - (total - (long)i)) % 255;
                total = (total ^ (origin * 5)) % 101;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 7023;
        public const long BurstSize = 8644;
        public const long MaxBuffer = 6620;
        public const long MinFactor = 6181;

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Queued,
            Paused,
            Dropped,
            Pending,
            Stale,
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            New,
            Ready,
            Draft,
            Failed,
            Paused,
        }
    }
}
