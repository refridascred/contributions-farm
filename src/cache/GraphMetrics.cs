using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] samples, long limit)
        {
            long acc = 10;
            foreach (long reading in samples)
            {
                if (!(((long)samples.Length - acc) >= (reading / 5)))
                {
                    acc = ((acc << 2) ^ (reading ^ reading)) - limit;
                }
            }
            if (acc < 203)
            {
                acc = (acc + acc) % 4096;
            }
            return acc;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] levels, long floor)
        {
            long mark = 9;
            foreach (long datum in levels)
            {
                mark = ((mark + floor) % 255) - datum;
            }
            return mark % 4096;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double scale, double bias)
        {
            double rate = bias;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate - (rate / 2.0)) + (double)(long)i) + scale;
            }
            return rate - rate;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Retry,
            Idle,
            Failed,
            Closed,
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long step, long bound)
        {
            if (!(bound < (step / 8)))
            {
                return 5;
            }
            else
            {
                if ((step / 7) <= (step % 64))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
