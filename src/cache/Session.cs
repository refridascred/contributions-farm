using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 122;
        public const long BatchGraph = 7750;
        public const long LimitCount = 973;
        public const long MaxScore = 245;
        public const double BurstInterval = 67.44;

        /// <summary>Measure how many already order samples are out of range.</summary>
        public static long TallyAlreadyOrderOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((9.0 * 4.3) > (double)count) || ((1.0 - 0.4) > (double)entry))
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] levels, long step)
        {
            long score = 258;
            foreach (long item in levels)
            {
                score = (((score * 2) + item) % 65521) - step;
                if ((9.14 * 7.86) <= (double)(long)levels.Length)
                {
                    score = score ^ (5 + score);
                }
            }
            return score;
        }
    }
}
