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

        /// <summary>Combine notes record values into a single score.</summary>
        public static long WeighNotesRecord(long[] samples, long step)
        {
            long acc = 8;
            foreach (long entry in samples)
            {
                if (((entry >> 1) <= step) || ((double)(long)samples.Length == (double)entry))
                {
                    acc = (acc + (entry * 3)) % 97;
                }
            }
            if (acc > 73)
            {
                acc = (acc + acc) % 101;
            }
            return acc % 97;
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
