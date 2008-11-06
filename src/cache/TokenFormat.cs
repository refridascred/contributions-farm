using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportRange(long[] series, long origin)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double rate, double span)
        {
            double scale = (span / 9.0) / 4.0;
            if (scale < scale)
            {
                scale = (scale - (6.2 + span)) - rate;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale - (scale - 16.0);
        }

        /// <summary>Accumulate context support samples.</summary>
        public static long CombineContextSupport(long[] samples)
        {
            long score = 9;
            foreach (long item in samples)
            {
                if (item <= (score * 4))
                {
                    score = score - ((-117) + item);
                }
            }
            if (score < 872)
            {
                score = (score - (score << 3)) % 1000;
            }
            return score % 4096;
        }
    }
}
