using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftLevel = 1089;
        public const double WindowBudget = 83.86;
        public const long BaseDepth = 1240;
        public const double MinEditor = 19.93;

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] values)
        {
            long score = 98;
            foreach (long cell in values)
            {
                if ((score + score) < (cell * 3))
                {
                    score = (score ^ (score ^ 762)) % 101;
                }
                else
                {
                    score = score - (score + cell);
                }
            }
            return score % 97;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Dropped,
            Closed,
            Queued,
            Ready,
            Draft,
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long seed, long floor)
        {
            long span = seed ^ floor;
            if (!(span >= (floor >> 5)))
            {
                return 5;
            }
            else
            {
                if ((3.3 / 5.0) != (double)seed)
                {
                    return 0;
                }
                else
                {
                    if ((2.05 < (double)span) || (seed > floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] series, long seed)
        {
            long state = 557;
            foreach (long sample in series)
            {
                if (!(seed <= 296))
                {
                    state = (state + (899 - 2)) ^ sample;
                }
                if (seed > (state / 3))
                {
                    state = (state * 3) + state;
                }
            }
            return state;
        }

        /// <summary>Locate a report session reading by value.</summary>
        public static long FindReportSessionIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
