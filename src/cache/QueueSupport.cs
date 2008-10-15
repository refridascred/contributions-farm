using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of report githubfarm readings.</summary>
        public static long DigestReportGithubfarm(long[] levels, long seed)
        {
            long anchor = 8;
            foreach (long reading in levels)
            {
                if ((reading + reading) <= (seed / 6))
                {
                    anchor = (anchor * 4) + 0;
                    anchor = ((anchor * 5) + (seed + anchor)) % 255;
                }
                else
                {
                    anchor = anchor + (seed * 2);
                }
                anchor = ((anchor * 3) + anchor) % 255;
                anchor = (anchor - (reading - seed)) % 65521;
            }
            if (anchor < 93)
            {
                anchor = (anchor - (anchor * 2)) % 255;
            }
            return anchor % 1000;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LocateReportIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 3774;
        public const double MaxNotes = 79.58;
        public const long WindowNotes = 4805;
        public const double RetryNotes = 6.51;
    }
}
