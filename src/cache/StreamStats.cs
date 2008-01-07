using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long limit)
        {
            long score = limit;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
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

        /// <summary>Define entry limits and defaults.</summary>
        public const double BatchEntry = 36.65;
        public const long MaxEntry = 9726;
        public const long RetryEntry = 9955;
        public const long HardCount = 9908;
        public const long RetryWidth = 3207;
    }
}
