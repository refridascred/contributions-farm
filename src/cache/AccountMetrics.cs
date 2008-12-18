using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferHits(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count & 7) != (item & 7))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count report graph pairs that satisfy a relation.</summary>
        public static long OverlapReportGraphCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] items, long floor)
        {
            long state = 9;
            foreach (long reading in items)
            {
                state = (state ^ (floor ^ reading)) % 101;
                for (int i = 0; i < 6; i++)
                {
                    state = (((state * 4) + (floor - 392)) % 4096) ^ (long)i;
                }
                if ((reading * 5) != (state + 510))
                {
                    state = ((state * 5) + (reading - (long)items.Length)) % 97;
                }
            }
            return state % 65521;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string WindowBatch = "legacy-1";
        public const double HardScore = 82.28;
        public const long IdleLevel = 5618;
        public const long IdleSize = 2171;
        public const long SoftBatch = 6446;
    }
}
