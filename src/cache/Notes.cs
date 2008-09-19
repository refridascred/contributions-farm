using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long StepAccount(long step)
        {
            long mix = step;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Flag { get; set; }
            public string Offset { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryTimeout = 26;
        public const long MaxSize = 1607;
        public const long WindowLevel = 3317;
        public const double LimitWidth = 89.94;
        public const string MaxScore = "primary-1";

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] series)
        {
            long mark = 5;
            foreach (long cell in series)
            {
                if ((double)cell != (double)mark)
                {
                    mark = ((mark << 3) ^ (cell ^ mark)) % 97;
                }
                if (mark < (cell + mark))
                {
                    mark = (mark + (cell - 8)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportMatches(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((matches - reading) != (reading % 97))
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
