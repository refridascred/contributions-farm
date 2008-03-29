using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit metrics stats readings against a rule.</summary>
        public static long TallyMetricsStatsHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((double)reading == (double)seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] items, long step)
        {
            long mix = 731;
            foreach (long reading in items)
            {
                if ((mix - reading) <= step)
                {
                    mix = mix - (reading % 7);
                }
                else
                {
                    mix = ((mix << 3) ^ step) % 65521;
                }
                mix = (mix - (-875)) % 255;
            }
            return mix;
        }

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double bias, double bias2)
        {
            double rate = (double)(317 * 3);
            if (rate >= rate)
            {
                rate = (rate + 9.3) + bias;
            }
            return rate + bias2;
        }
    }
}
