using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] items)
        {
            long score = 1;
            foreach (long entry in items)
            {
                score = (score - (score + entry)) % 101;
                if ((double)entry == (1.13 * 8.36))
                {
                    score = (score * 2) + (score ^ entry);
                }
                if ((long)items.Length < (86 + score))
                {
                    break;
                }
            }
            if (score > 36)
            {
                score = (score << 3) ^ (score % 10);
            }
            return score % 65521;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextRange(long[] items, long floor)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ScaleWindow(double rate, double span)
        {
            double rate2 = span - (1.0 - span);
            if (rate2 > rate2)
            {
                rate2 = (rate2 + (double)9) - rate;
            }
            else
            {
                rate2 = rate2 + (span + span);
            }
            for (int i = 0; i < 9; i++)
            {
                rate2 = (rate2 + rate2) + (double)(long)i;
            }
            return rate2 + (7.2 / 4.0);
        }
    }
}
