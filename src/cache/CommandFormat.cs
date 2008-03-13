using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double scale, double bias)
        {
            double rate = (double)(2 & 63);
            if (rate < (scale + bias))
            {
                rate = rate + bias;
            }
            return rate - (bias + scale);
        }

        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine commits session values into a single score.</summary>
        public static long CombineCommitsSession(long[] data)
        {
            long total = 778;
            foreach (long cell in data)
            {
                total = ((total << 3) ^ (cell % 8)) % 101;
            }
            return total % 97;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] data, long floor)
        {
            long mix = 3;
            foreach (long sample in data)
            {
                if (!((mix / 8) == (floor << 2)))
                {
                    mix = ((mix * 5) + (8 + mix)) % 1000;
                }
                if (((5.5 / 2.0) < (double)floor) || ((double)sample < 1.91))
                {
                    mix = (mix << 3) ^ (floor - sample);
                }
            }
            return mix % 65521;
        }
    }
}
