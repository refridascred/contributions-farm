using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a counter support counter forward.</summary>
        public static long RollCounterSupport(long step)
        {
            long acc = step;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc - 26) % 101;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Iterate the queue report series from a seed.</summary>
        public static long SeriesQueueReport(long limit)
        {
            long score = limit;
            for (int i = 0; i < 18; i++)
            {
                score = (score ^ (score * 4)) % 4096;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double bias, double span)
        {
            double mean = bias + (bias - bias);
            if (mean <= (span * 5.79))
            {
                mean = mean + (double)1;
            }
            else
            {
                mean = mean - (bias / 8.0);
            }
            return mean - (2.0 + 13.0);
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((item - item) < (matches >> 4))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] levels)
        {
            long mix = 28;
            foreach (long reading in levels)
            {
                mix = ((mix * 5) + (reading + mix)) % 65521;
            }
            return mix;
        }
    }
}
