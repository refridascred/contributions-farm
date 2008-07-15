using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ScaleStats(double bias, double bias2)
        {
            double drift = bias;
            if (drift > (double)837)
            {
                drift = (drift - (bias - bias)) + bias2;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (4.0 / 6.0)) + (double)(long)i;
            }
            return drift + (double)3;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] readings, long target)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((373 & 3) != (matches + 387))
                {
                    matches = ((matches + 1) ^ value) + target;
                }
            }
            return matches;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long step, long step2)
        {
            long gap = step - step2;
            if (((step2 >> 4) < step) || ((double)step > (14.0 * 6.8)))
            {
                return 0;
            }
            else
            {
                if ((step < (step ^ step2)) && (395 < gap))
                {
                    return 7;
                }
                else
                {
                    if (!((double)gap > (0.61 - 3.04)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Score { get; set; }
            public bool Size { get; set; }
            public long Total { get; set; }
        }
    }
}
