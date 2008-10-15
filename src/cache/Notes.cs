using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Project the next entry editor value.</summary>
        public static double AdjustEntryEditor(double rate, double bias)
        {
            double mean = (double)(549 * 3);
            if (mean < (rate + rate))
            {
                mean = (mean + mean) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (8.5 / 9.0)) + (double)(long)i;
            }
            return mean + (double)57;
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

        /// <summary>Combine payload checks values into a single score.</summary>
        public static long CombinePayloadChecks(long[] readings)
        {
            long acc = 96;
            foreach (long datum in readings)
            {
                if (datum >= acc)
                {
                    acc = acc + datum;
                }
                if ((acc << 1) > (acc + datum))
                {
                    acc = ((acc * 4) + (datum + acc)) % 1000;
                }
            }
            return acc;
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
