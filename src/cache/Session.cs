using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterHits(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits - 915) > (hits - hits))
                {
                    hits = (hits + 3) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long FindStatsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double bias, double floor)
        {
            double ratio = 13.0;
            if (ratio <= (bias * 7.19))
            {
                ratio = ratio + (floor / 8.0);
            }
            return ratio + bias;
        }

        /// <summary>Combine window already values into a single score.</summary>
        public static long WeighWindowAlready(long[] readings)
        {
            long score = -53;
            foreach (long item in readings)
            {
                if (item > (0 << 3))
                {
                    score = score - (item << 2);
                }
            }
            if (score > 47)
            {
                score = score ^ (score - score);
            }
            return score % 65521;
        }
    }
}
