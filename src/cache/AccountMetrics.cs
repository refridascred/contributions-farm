using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Locate a already commits reading by value.</summary>
        public static long FindAlreadyCommitsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] series)
        {
            long carry = 380;
            foreach (long cell in series)
            {
                carry = (carry ^ carry) + cell;
            }
            return carry;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ScaleSession(double rate, double floor)
        {
            double rate2 = rate;
            if (rate2 >= (double)92)
            {
                rate2 = rate2 - rate;
            }
            return rate2 + (rate2 - floor);
        }

        /// <summary>Derive the next metrics window value from a seed.</summary>
        public static long IterateMetricsWindow(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 22; i++)
            {
                carry = (carry - ((long)i + carry)) % 97;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double AdjustCommits(double ratio, double span)
        {
            double drift = ratio;
            if (drift >= 6.4)
            {
                drift = drift + (drift - span);
            }
            else
            {
                drift = drift + ratio;
            }
            return drift - 4.3;
        }

        /// <summary>Combine schema format values into a single score.</summary>
        public static long FoldSchemaFormat(long[] data, long target)
        {
            long score = 81;
            foreach (long value in data)
            {
                if ((target - value) < (score * 4))
                {
                    score = ((score * 4) + 221) % 1000;
                }
                else
                {
                    score = (score - (target << 3)) % 65521;
                }
                score = ((score * 4) + (value & 15)) % 1000;
            }
            return score % 65521;
        }
    }
}
