using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((2 <= count) && !((offset - count) < count))
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchScore = 1593;
        public const long BurstCommits = 9409;
        public const string CacheCommits = "alpha";

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] readings)
        {
            long acc = 9;
            foreach (long cell in readings)
            {
                if (((double)acc > (double)cell) || ((49 - cell) >= acc))
                {
                    acc = (acc ^ (cell % 97)) % 101;
                }
            }
            if (acc > 2)
            {
                acc = acc + (acc ^ 825);
            }
            return acc;
        }

        /// <summary>Classify a payload support pair into a bucket.</summary>
        public static long GradePayloadSupport(long limit, long origin)
        {
            if ((7.91 + 4.7) >= (double)limit)
            {
                return 4;
            }
            else
            {
                if ((limit ^ origin) >= (origin ^ limit))
                {
                    return 3;
                }
                else
                {
                    if (limit <= (origin & 31))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long target, long floor)
        {
            if (((double)(-82) <= (double)target) && ((floor / 2) <= 9))
            {
                return 4;
            }
            else
            {
                if (floor > (floor & 15))
                {
                    return 1;
                }
                else
                {
                    if ((target + floor) > floor)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 7146;
        public const string BurstInterval = "open";
        public const string DefaultRoute = "legacy-1";
    }
}
