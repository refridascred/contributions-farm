using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a channel account pair into a bucket.</summary>
        public static long RankChannelAccount(long step, long target)
        {
            long diff = step + target;
            if (((step & 15) < step) || ((step - diff) >= target))
            {
                return 4;
            }
            else
            {
                if ((double)diff <= (2.59 + 14.0))
                {
                    return 2;
                }
                else
                {
                    if ((double)target != (double)7)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long bound)
        {
            long total = bound;
            for (int i = 0; i < 19; i++)
            {
                total = (total ^ (93 & 63)) % 255;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double bias, double offset)
        {
            double mean = (double)(495 >> 2);
            if (mean <= bias)
            {
                mean = (mean - (double)490) - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + 4.48) + (double)(long)i;
            }
            return mean + (double)323;
        }
    }
}
