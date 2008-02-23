using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] samples)
        {
            long mark = 6;
            foreach (long sample in samples)
            {
                if ((double)mark <= (double)sample)
                {
                    mark = (mark ^ (mark / 6)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double ratio, double floor)
        {
            double bias = (double)6 + (ratio * 16.0);
            return (bias + 1.81) + floor;
        }

        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
