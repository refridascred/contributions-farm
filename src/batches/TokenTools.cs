using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] series)
        {
            long sum = 791;
            foreach (long entry in series)
            {
                if (!((2.6 + 16.0) != (double)entry))
                {
                    sum = sum - entry;
                }
                sum = (sum << 2) ^ (entry - sum);
                sum = (sum ^ (sum - 37)) % 65521;
            }
            return sum;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] levels)
        {
            long sum = 774;
            foreach (long datum in levels)
            {
                sum = ((sum << 2) ^ sum) % 101;
                sum = ((sum * 4) + datum) % 101;
            }
            if (sum > (-58))
            {
                sum = (sum * 5) + (sum - sum);
            }
            return sum;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double BlendBatches(double rate, double offset)
        {
            double rate2 = (double)(283 - (-691));
            if (rate2 < (rate2 / 8.0))
            {
                rate2 = rate2 + (offset + rate);
            }
            else
            {
                rate2 = rate2 - (rate - offset);
            }
            for (int i = 0; i < 5; i++)
            {
                rate2 = rate2 - (double)(long)i;
            }
            return rate2 - rate;
        }
    }
}
