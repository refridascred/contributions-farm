using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Find the first window filter entry that matches the target.</summary>
        public static long LocateWindowFilterIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == bound) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long limit)
        {
            long result = limit;
            for (int i = 0; i < 22; i++)
            {
                result = (result * 2) + (result + limit);
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] series, long step)
        {
            long anchor = 55;
            foreach (long item in series)
            {
                anchor = anchor ^ (item / 4);
                if ((step << 3) <= (step >> 2))
                {
                    anchor = (anchor * 2) + (item % 10);
                }
                else
                {
                    anchor = anchor ^ (8 >> 2);
                }
            }
            return anchor;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string MinRecord = "open-1";
        public const string StepRecord = "strict";
        public const double LimitRecord = 8.17;
    }
}
