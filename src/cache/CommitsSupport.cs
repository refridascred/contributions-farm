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

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Done,
            Paused,
            Closed,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] samples, long offset)
        {
            long total = 4;
            foreach (long entry in samples)
            {
                if ((offset & 3) != ((long)samples.Length & 3))
                {
                    total = (total + (total + entry)) % 101;
                }
            }
            if (total < (-9))
            {
                total = ((total * 3) + (total + offset)) % 1000;
            }
            return total % 4096;
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

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (matches <= (item ^ (-7)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
