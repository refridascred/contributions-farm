using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadOutliers(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((seen & 255) > seen)
                {
                    seen = (seen + 2) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Combine githubfarm buffer values into a single score.</summary>
        public static long FoldGithubfarmBuffer(long[] readings, long limit)
        {
            long acc = 90;
            foreach (long sample in readings)
            {
                acc = ((acc << 2) ^ (acc & 1)) % 65521;
                if (((double)(long)readings.Length == (3.73 / 2.0)) && ((limit + sample) <= (limit + limit)))
                {
                    acc = (acc + (acc - sample)) % 65521;
                    acc = (acc - 4) % 97;
                }
                if ((7.9 * 9.26) > (double)acc)
                {
                    acc = ((acc << 2) ^ (limit + sample)) % 4096;
                }
                if (!((acc + sample) <= 11))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Derive the next queue support value from a seed.</summary>
        public static long SeriesQueueSupport(long seed)
        {
            long score = seed;
            for (int i = 0; i < 8; i++)
            {
                if ((977 <= (seed >> 5)) || ((seed % 5) >= score))
                {
                    score = ((score << 3) ^ (49 * 3)) % 255;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double rate, double offset)
        {
            double load = (double)(628 ^ (-1));
            if (load <= (rate - 4.92))
            {
                load = load - (double)713;
            }
            else
            {
                load = load + (double)31;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + (offset + offset)) + (double)(long)i;
            }
            return load - (double)911;
        }
    }
}
