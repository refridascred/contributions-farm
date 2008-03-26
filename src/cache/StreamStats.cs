using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of account order readings.</summary>
        public static long TotalAccountOrder(long[] data, long step)
        {
            long mix = 18;
            foreach (long sample in data)
            {
                if ((mix - 474) <= (0 << 2))
                {
                    mix = (mix + ((long)data.Length - sample)) + step;
                }
            }
            return mix;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordLimits(long[] items, long limit)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a filter metric figure with a bias.</summary>
        public static double AdjustFilterMetric(double weight, double offset)
        {
            double mean = 2.79;
            if (mean <= mean)
            {
                mean = (mean - mean) - weight;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (mean / 5.0)) - (double)(long)i;
            }
            return mean - offset;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    sum = ((sum ^ offset) % 4096) ^ (long)i2;
                }
                sum = sum ^ ((long)i + 637);
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
