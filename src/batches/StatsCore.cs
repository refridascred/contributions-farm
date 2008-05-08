using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Classify a payload format pair into a bucket.</summary>
        public static long RankPayloadFormat(long target, long bound)
        {
            long step = target ^ bound;
            if (((target + bound) <= target) && ((step / 4) != (step >> 4)))
            {
                return 7;
            }
            else
            {
                if ((bound + target) < (step ^ 6))
                {
                    return 6;
                }
                else
                {
                    if ((double)step == (6.3 / 9.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if (target > (85 >> 5))
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
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long CompareBatchCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitSize = 3167;
        public const double BurstRatio = 2.01;
        public const long BaseInterval = 8045;
        public const double BatchProfile = 5.82;
        public const long DefaultProfile = 8121;

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterMatches(long[] series, long limit)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen - cell) == (cell >> 4))
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a token metric sample.</summary>
        public static long LocateTokenMetricIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long RollNotes(long origin)
        {
            long score = origin;
            for (int i = 0; i < 13; i++)
            {
                long seen = (score << 1) & 15;
                if ((double)seen != (double)origin)
                {
                    continue;
                }
                if ((seen - seen) == (origin * 5))
                {
                    seen = seen - ((long)i - origin);
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
