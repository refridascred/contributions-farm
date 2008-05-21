using System;

namespace Common.Utilities
{
    /// <summary>Already stats helpers.</summary>
    public static class AlreadyStats
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((count / 4) < (cell + 970)) && !((5 - count) <= (34 >> 3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double rate, double offset)
        {
            double drift = offset;
            if (drift <= (offset + 8.32))
            {
                drift = drift - (double)18;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (rate * 10.0)) + (double)(long)i;
            }
            return drift + (offset + rate);
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
