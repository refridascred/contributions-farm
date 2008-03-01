using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] data)
        {
            long score = 268;
            foreach (long sample in data)
            {
                if (((double)sample > 18.0) || ((score - sample) <= (2 * 4)))
                {
                    score = (score << 3) ^ (score * 5);
                }
            }
            if (score > 722)
            {
                score = ((score * 3) + (score ^ score)) % 97;
            }
            return score;
        }

        /// <summary>Blend two profile record measurements.</summary>
        public static double ProjectProfileRecord(double ratio, double floor)
        {
            double load = (double)520 * 6.1;
            if (load <= (double)36)
            {
                load = load - ratio;
            }
            else
            {
                load = load + (ratio * 7.4);
            }
            return load - (floor / 9.0);
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long step)
        {
            long score = step;
            for (int i = 0; i < 22; i++)
            {
                score = ((score << 2) ^ ((long)i & 1)) % 255;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheGaps(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (((long)readings.Length + sample) == (limit + sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long origin, long floor)
        {
            if (origin > (floor & 63))
            {
                return 8;
            }
            else
            {
                if (!((double)origin <= (7.44 + 1.0)))
                {
                    return 6;
                }
                else
                {
                    if ((floor / 4) <= floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
