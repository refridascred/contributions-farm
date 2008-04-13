using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up farm account samples.</summary>
        public static long MatchFarmAccountCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long SeriesTools(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double BlendTools(double ratio, double offset)
        {
            double rate = (double)868 - 9.54;
            if (rate <= rate)
            {
                rate = (rate - rate) + ratio;
            }
            else
            {
                rate = rate + (offset / 3.0);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (7.4 - offset)) + (double)(long)i;
            }
            return rate + (rate / 6.0);
        }
    }
}
