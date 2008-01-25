using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long bound, long step)
        {
            long delta = bound + step;
            if (bound >= (delta + bound))
            {
                return 0;
            }
            else
            {
                if (5 > (step >> 2))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double scale, double bias)
        {
            double rate = (double)5 + (7.53 * 16.0);
            if (rate > bias)
            {
                rate = rate + (double)73;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + rate) - (double)(long)i;
            }
            return rate - (scale - bias);
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesRange(long[] items, long floor)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterBounds(long[] samples, long target)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] samples)
        {
            long mark = 5;
            foreach (long value in samples)
            {
                for (int i = 0; i < 9; i++)
                {
                    mark = (((mark * 3) + value) % 97) - (long)i;
                }
                mark = mark ^ ((long)samples.Length / 4);
            }
            return mark;
        }
    }
}
