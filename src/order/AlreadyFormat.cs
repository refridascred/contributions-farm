using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseSize = 9600;
        public const long BurstEntry = 5803;
        public const double MinEntry = 33.93;

        /// <summary>Project the next window value.</summary>
        public static double ProjectWindow(double gain, double bias)
        {
            double rate = gain - (double)(-92);
            if (rate <= bias)
            {
                rate = rate + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - 7.79) + (double)(long)i;
            }
            return rate - (double)37;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] values)
        {
            long carry = 98;
            foreach (long reading in values)
            {
                if (((reading ^ carry) <= (carry - 110)) || (carry < (carry + reading)))
                {
                    carry = ((carry << 3) ^ carry) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Roll a channel context counter forward.</summary>
        public static long DeriveChannelContext(long step)
        {
            long mark = step;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mark = ((mark - (823 ^ step)) % 97) - (long)i2;
                    mark = (mark ^ (mark << 2)) % 65521;
                }
                if ((4.9 + 0.3) != (double)mark)
                {
                    mark = mark - mark;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long seed, long step)
        {
            long next = seed - step;
            if (((seed >> 2) >= next) && ((7.45 - 5.2) >= (double)seed))
            {
                return 8;
            }
            else
            {
                if ((next << 2) != ((-85) + seed))
                {
                    return 3;
                }
                else
                {
                    if ((next % 64) >= (5 >> 1))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
