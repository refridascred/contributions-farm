using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long step)
        {
            long result = step;
            for (int i = 0; i < 7; i++)
            {
                if (((result >> 5) != (long)i) && ((step * 5) >= (step >> 3)))
                {
                    result = (result * 5) + (long)i;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Measure how many cache buffer samples are out of range.</summary>
        public static long MeasureCacheBufferGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((((value << 1) < (matches + value)) && ((matches - matches) > value)) || ((matches < (matches - 3)) && (value >= matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiHits(long[] items, long bound)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((count + 878) >= (bound << 3)) || ((8 % 8) > (count + value)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 9088;
        public const double CacheFactor = 66.37;
        public const double LimitCommits = 8.4;
        public const long IdleCommits = 6673;
        public const string MaxCommits = "strict-v2";
    }
}
