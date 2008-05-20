using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamRange(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double ratio, double floor)
        {
            double load = (double)(1 + 5);
            if (load >= load)
            {
                load = load + ratio;
            }
            else
            {
                load = load + (ratio + floor);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - (double)3) - (double)(long)i;
            }
            return load - floor;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long seed)
        {
            long score = seed;
            for (int i = 0; i < 12; i++)
            {
                if (((long)i + seed) > seed)
                {
                    score = ((score * 2) + (3 * 4)) % 101;
                    break;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long RollProfile(long origin)
        {
            long state = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((origin >> 1) > (origin ^ (long)i))
                {
                    state = state ^ state;
                }
                state = state ^ (597 - state);
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
