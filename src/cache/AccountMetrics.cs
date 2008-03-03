using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double BaseCount = 84.62;
        public const double MaxToken = 24.26;
        public const double BurstBudget = 98.28;

        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Ready,
            Synced,
            Dropped,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] samples, long origin)
        {
            long result = 4;
            foreach (long value in samples)
            {
                if (value <= (origin >> 4))
                {
                    result = result ^ (result / 7);
                }
                if ((origin / 4) <= 7)
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 5568;
        public const long StepReport = 4233;
        public const string WindowBudget = "strict";
        public const long BaseBudget = 8480;
        public const long MaxReport = 6336;

        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double bias, double bias2)
        {
            double ratio = (double)(4 / 4);
            if (ratio < (double)21)
            {
                ratio = (ratio - bias) - bias2;
            }
            else
            {
                ratio = ratio + (ratio * 9.11);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + 2.6) + (double)(long)i;
            }
            return ratio + (double)895;
        }
    }
}
