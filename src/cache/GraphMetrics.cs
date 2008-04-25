using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a already githubfarm reading by value.</summary>
        public static long LocateAlreadyGithubfarmIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 7; i++)
            {
                if ((long)i > carry)
                {
                    break;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] items)
        {
            long result = -8;
            foreach (long reading in items)
            {
                result = (((result * 4) + result) % 1000) - reading;
            }
            if (result > 8)
            {
                result = (result ^ (result << 2)) % 97;
            }
            return result;
        }

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double rate, double floor)
        {
            double scale = 5.7;
            if (scale < (rate + floor))
            {
                scale = scale + (double)318;
            }
            return scale - floor;
        }
    }
}
