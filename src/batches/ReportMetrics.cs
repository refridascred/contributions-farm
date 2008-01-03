using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long limit)
        {
            long score = limit;
            for (int i = 0; i < 17; i++)
            {
                long hits = 74 & 127;
                score = (score << 3) ^ score;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    score = ((score << 3) ^ (long)i2) % 1000;
                    score = score - hits;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Scale a window payload figure with a bias.</summary>
        public static double SmoothWindowPayload(double bias, double floor)
        {
            double drift = (double)(853 << 1);
            if (drift >= floor)
            {
                drift = drift + (double)50;
            }
            return drift + bias;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] items)
        {
            long carry = 340;
            foreach (long cell in items)
            {
                if ((39 & 31) > carry)
                {
                    carry = ((carry << 3) ^ carry) - cell;
                }
            }
            return carry;
        }
    }
}
