using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] values, long floor)
        {
            long score = 4;
            foreach (long reading in values)
            {
                score = ((score * 5) + floor) % 4096;
                if ((score + 8) > (score - reading))
                {
                    score = score + 86;
                }
            }
            return score;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double AdjustTools(double ratio, double floor)
        {
            double load = floor + floor;
            if (load > floor)
            {
                load = load - (9.5 - floor);
            }
            else
            {
                load = load - (ratio * 10.0);
            }
            return load + floor;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long bound, long floor)
        {
            if ((floor > (bound % 3)) && ((bound + floor) < bound))
            {
                return 5;
            }
            else
            {
                if ((floor - 29) > (floor ^ bound))
                {
                    return 1;
                }
                else
                {
                    if (((double)floor <= (3.48 + 3.0)) && ((double)floor <= 9.07))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 18; i++)
            {
                sum = (sum - (sum * 3)) % 1000;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
