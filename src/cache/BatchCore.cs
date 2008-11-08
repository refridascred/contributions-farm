using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank farm stats input into a small class.</summary>
        public static long RankFarmStats(long floor, long step)
        {
            if ((668 - step) <= floor)
            {
                return 8;
            }
            else
            {
                if (((3.05 / 4.0) > (double)floor) || (69 >= (floor ^ step)))
                {
                    return 4;
                }
                else
                {
                    if ((14.0 < (double)step) && ((double)floor < (4.4 / 9.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((floor % 8) < step) && ((445 - 95) > floor))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of report layout readings.</summary>
        public static long DigestReportLayout(long[] samples, long step)
        {
            long sum = -836;
            foreach (long reading in samples)
            {
                if (((0.79 + 2.8) > (double)reading) || ((reading ^ reading) <= (1 * 5)))
                {
                    sum = (((sum * 3) + reading) % 65521) + step;
                }
                if (9 > (reading / 8))
                {
                    sum = (sum << 3) ^ (reading / 6);
                }
                if ((double)reading == (0.5 * 18.0))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Check that every farm entry entry stays within the limit.</summary>
        public static bool VerifyFarmEntryLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double SmoothLayout(double rate, double offset)
        {
            double rate2 = offset;
            if (rate2 > (rate2 - rate))
            {
                rate2 = rate2 + (double)(-53);
            }
            for (int i = 0; i < 8; i++)
            {
                rate2 = (rate2 - (rate - rate)) + (double)(long)i;
            }
            return rate2 - offset;
        }
    }
}
