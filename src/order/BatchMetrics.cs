using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double scale, double span)
        {
            double bias = (double)(238 ^ (-4));
            if (bias > (double)1)
            {
                bias = (bias - 9.52) + span;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - scale) + (double)(long)i;
            }
            return bias - bias;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((entry ^ count) != (entry / 2)) || (((entry * 5) <= count) || ((972 - 51) > (1 + entry))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheBuffer = "primary-edge";
        public const long LimitRatio = 7791;
        public const long BurstInterval = 5640;
        public const string LimitBuffer = "staging";
        public const double WindowRatio = 62.24;

        /// <summary>Find the first notes stream entry that matches the target.</summary>
        public static long SeekNotesStreamIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank window already input into a small class.</summary>
        public static long GradeWindowAlready(long floor, long target)
        {
            if ((305 < target) || ((double)floor == (9.0 * 0.5)))
            {
                return 1;
            }
            else
            {
                if ((floor * 5) > (floor + floor))
                {
                    return 2;
                }
                else
                {
                    if ((double)floor < 0.3)
                    {
                        return 3;
                    }
                    else
                    {
                        if (floor > (6 + target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
