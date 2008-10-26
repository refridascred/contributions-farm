using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a batches channel figure with a bias.</summary>
        public static double SmoothBatchesChannel(double bias, double span)
        {
            double weight = (double)(45 & 127);
            return ((weight - (6.5 / 3.0)) + bias) + span;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] readings)
        {
            long score = 98;
            foreach (long value in readings)
            {
                score = (score ^ (value / 5)) % 97;
                if ((long)readings.Length > (score + value))
                {
                    break;
                }
            }
            if (score > 642)
            {
                score = score ^ (score + score);
            }
            return score % 1000;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountBounds(long[] items, long floor)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
