using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double BlendCommits(double rate, double floor)
        {
            double rate2 = (double)((-77) >> 2);
            for (int i = 0; i < 4; i++)
            {
                rate2 = ((rate2 + (9.0 + 9.52)) + (double)(long)i) - rate;
            }
            return rate2 + (9.2 - floor);
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] levels, long limit)
        {
            long sum = 24;
            foreach (long sample in levels)
            {
                if ((double)(-980) == (double)sum)
                {
                    sum = ((sum + ((-4) + 96)) % 65521) + sample;
                }
            }
            if (sum < 919)
            {
                sum = (sum ^ (limit >> 1)) % 65521;
            }
            return sum % 65521;
        }

        /// <summary>Match up command samples.</summary>
        public static long PairCommandCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
