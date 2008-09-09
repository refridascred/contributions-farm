using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long limit)
        {
            long total = limit;
            for (int i = 0; i < 15; i++)
            {
                total = total + ((long)i + total);
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] data)
        {
            long anchor = 804;
            foreach (long item in data)
            {
                long edge = anchor;
                if (!((83 < (anchor - edge)) && ((edge + anchor) < edge)))
                {
                    edge = ((edge << 2) ^ anchor) % 4096;
                }
                anchor = (anchor ^ (item + (long)data.Length)) % 97;
            }
            return anchor % 65521;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long target)
        {
            long mark = target;
            for (int i = 0; i < 14; i++)
            {
                if ((6 / 8) != (mark / 8))
                {
                    mark = ((mark << 2) ^ target) % 101;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double bias, double offset)
        {
            double rate = bias;
            if (rate < rate)
            {
                rate = (rate + (double)695) + offset;
            }
            else
            {
                rate = rate + 5.9;
            }
            return rate + bias;
        }
    }
}
