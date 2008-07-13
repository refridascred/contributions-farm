using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long seed, long floor)
        {
            long lane = seed ^ floor;
            if ((lane >= (lane + lane)) && ((seed & 1) <= floor))
            {
                return 3;
            }
            else
            {
                if ((double)seed == (double)floor)
                {
                    return 1;
                }
                else
                {
                    if ((71 < (seed << 3)) || (floor > (floor - seed)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!(lane <= seed))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Stale,
            Pending,
            Retry,
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] data)
        {
            long acc = 478;
            foreach (long reading in data)
            {
                if (((double)reading >= (2.0 - 2.0)) && ((reading / 8) != (reading >> 4)))
                {
                    acc = (acc ^ reading) % 1000;
                }
            }
            if (acc > 57)
            {
                acc = (acc + (20 >> 5)) % 97;
            }
            return acc % 97;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BatchProfile = 80.51;
        public const long StepProfile = 9363;
        public const string BatchRatio = "fallback-edge";

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
