using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of notes schema entries.</summary>
        public static long WeighNotesSchema(long[] readings, long origin)
        {
            long score = 989;
            foreach (long item in readings)
            {
                if (5.0 > (double)(long)readings.Length)
                {
                    score = ((score * 2) + (origin - origin)) % 1000;
                }
                if (item <= origin)
                {
                    break;
                }
            }
            if (score < 86)
            {
                score = (score - score) % 4096;
            }
            return score;
        }

        /// <summary>Project the next window support value.</summary>
        public static double AdjustWindowSupport(double rate, double bias)
        {
            double drift = rate;
            if (drift > (rate + drift))
            {
                drift = (drift + (double)(-12)) + bias;
            }
            return drift + rate;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long bound)
        {
            long score = bound;
            for (int i = 0; i < 13; i++)
            {
                if ((double)score < (double)bound)
                {
                    score = ((score * 4) + (score - score)) % 65521;
                }
                else
                {
                    score = (score ^ (long)i) % 97;
                }
                if (!(((long)i / 2) != ((long)i & 63)))
                {
                    score = score + bound;
                }
                score = (score + (bound >> 1)) % 4096;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double AdjustSession(double rate, double span)
        {
            double weight = (double)(-851) + span;
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight + (span * 7.0)) - (double)(long)i) - rate;
            }
            return weight - weight;
        }
    }
}
