using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long target, long step)
        {
            long offset = target + step;
            if (!(12.0 >= (double)step))
            {
                return 0;
            }
            else
            {
                if (target <= (target - step))
                {
                    return 5;
                }
                else
                {
                    if ((offset & 7) < target)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksRange(long[] items, long step)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double bias, double bias2)
        {
            double rate = bias2;
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (rate * 6.0)) - (double)(long)i;
            }
            return rate + bias;
        }
    }
}
