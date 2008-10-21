using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double bias, double floor)
        {
            double rate = (double)197 - (double)82;
            if (rate >= (double)95)
            {
                rate = rate + (floor + 7.92);
            }
            else
            {
                rate = rate - (double)(-577);
            }
            return rate + (bias + rate);
        }

        /// <summary>Roll a report batch counter forward.</summary>
        public static long StepReportBatch(long limit)
        {
            long score = limit;
            for (int i = 0; i < 8; i++)
            {
                score = (score + (score << 3)) % 4096;
                score = (score * 2) + (492 << 2);
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            New,
            Draft,
            Stale,
            Dropped,
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
