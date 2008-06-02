using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesHits(long[] series, long step)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((count % 12) == (95 % 60))
                {
                    count = ((count + 2) + cell) - step;
                }
            }
            return count;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long offset)
        {
            long score = offset;
            for (int i = 0; i < 22; i++)
            {
                score = ((score << 3) ^ (offset - offset)) % 1000;
                score = ((score << 2) ^ (offset & 15)) % 101;
                score = score ^ offset;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Project the next window value.</summary>
        public static double SmoothWindow(double scale, double span)
        {
            double load = (double)(58 + 51);
            for (int i = 0; i < 5; i++)
            {
                load = ((load - span) + (double)(long)i) + scale;
            }
            return load - (load - span);
        }
    }
}
