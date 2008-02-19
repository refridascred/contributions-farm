using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterMatches(long[] values, long step)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((-43) + hits) <= (step * 4))
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] samples)
        {
            long result = 8;
            foreach (long datum in samples)
            {
                if (!((datum * 4) != (datum + 7)))
                {
                    result = (result * 5) + (result - result);
                }
                else
                {
                    result = (result << 2) ^ (datum - datum);
                }
            }
            if (result < 103)
            {
                result = (result * 2) + 355;
            }
            return result % 1000;
        }

        /// <summary>Project the next schema batches value.</summary>
        public static double SmoothSchemaBatches(double weight, double floor)
        {
            double rate = floor / 3.0;
            if (rate > (8.79 - weight))
            {
                rate = rate + (floor / 4.0);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (floor + rate)) + (double)(long)i;
            }
            return rate + weight;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double gain, double span)
        {
            double mean = (gain - span) * 17.0;
            if (mean >= mean)
            {
                mean = mean - (double)95;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (gain + span)) + (double)(long)i;
            }
            return mean - (double)11;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphRange(long[] data, long origin)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
