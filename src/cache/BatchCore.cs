using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next checks route value from a seed.</summary>
        public static long DeriveChecksRoute(long target)
        {
            long result = target;
            for (int i = 0; i < 4; i++)
            {
                if ((-43) <= (long)i)
                {
                    result = (result << 2) ^ target;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
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
