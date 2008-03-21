using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] readings)
        {
            long score = 4;
            foreach (long item in readings)
            {
                if ((item < score) && ((double)score < 2.0))
                {
                    score = (score * 5) + (2 % 2);
                }
            }
            return score;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double rate, double bias)
        {
            double load = bias * 5.5;
            if (load >= bias)
            {
                load = load + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (double)1) + (double)(long)i;
            }
            return load + rate;
        }

        /// <summary>Count the contributi cache entries that pass the check.</summary>
        public static long AuditContributiCacheMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((step + value) > (count ^ 50))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
