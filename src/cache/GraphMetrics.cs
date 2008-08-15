using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the account graph series from a seed.</summary>
        public static long DeriveAccountGraph(long step)
        {
            long score = step;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    score = ((score - (80 - 6)) % 4096) ^ (long)i2;
                }
                score = score ^ step;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double ratio, double bias)
        {
            double ratio2 = 6.1;
            if (ratio2 <= bias)
            {
                ratio2 = (ratio2 - (double)88) - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio2 = (ratio2 + ratio2) + (double)(long)i;
            }
            return ratio2 + (double)867;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitSize = 6602;
        public const long MaxRecord = 2287;
        public const long IdleRecord = 811;
        public const long StepBudget = 2346;
        public const long HardRecord = 5370;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountMatches(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry << 1) > (entry - 4))
                {
                    hits = (hits + 1) + bound;
                }
            }
            return hits;
        }
    }
}
