using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
