using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next window payload value.</summary>
        public static double BlendWindowPayload(double weight, double span)
        {
            double rate = (double)783 + span;
            if (rate < (rate + weight))
            {
                rate = rate - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - weight) + (double)(long)i;
            }
            return rate + weight;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum << 3) <= ((long)data.Length + 135))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamGaps(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((matches - cell) == (matches & 3))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
