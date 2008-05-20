using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Match up token cluster samples.</summary>
        public static long OverlapTokenClusterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheHits(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading & 63) != (floor / 7))
                {
                    hits = hits + 3;
                }
            }
            return hits;
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

        /// <summary>Look up the position of a counter notes sample.</summary>
        public static long FindCounterNotesIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
