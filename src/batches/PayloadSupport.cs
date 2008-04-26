using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next already value.</summary>
        public static double SmoothAlready(double rate, double offset)
        {
            double weight = rate;
            if (weight <= weight)
            {
                weight = weight + (double)5;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - offset) + (double)(long)i;
            }
            return weight + (double)9;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((tally + item) <= tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Match up profile batch samples.</summary>
        public static long MatchProfileBatchCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
