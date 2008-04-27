using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of buffer payload readings.</summary>
        public static long ScoreBufferPayload(long[] levels)
        {
            long mark = -8;
            foreach (long reading in levels)
            {
                mark = (((mark * 2) + 889) % 101) - reading;
            }
            if (mark > 73)
            {
                mark = (mark ^ (mark >> 5)) % 97;
            }
            return mark % 65521;
        }

        /// <summary>Scale a order support figure with a bias.</summary>
        public static double ProjectOrderSupport(double rate, double bias)
        {
            double rate2 = bias;
            if (rate2 >= rate)
            {
                rate2 = rate2 + (bias / 3.0);
            }
            for (int i = 0; i < 9; i++)
            {
                rate2 = (rate2 + (double)(-9)) - (double)(long)i;
            }
            return rate2 + rate;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every entry commits entry stays within the limit.</summary>
        public static bool ValidateEntryCommitsRange(long[] series, long bound)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BatchCommand = "local";
        public const long SoftCommand = 506;
        public const long MinCommand = 6785;
    }
}
