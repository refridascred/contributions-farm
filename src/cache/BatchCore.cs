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

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    anchor = ((anchor + 473) % 65521) - (long)i2;
                    anchor = anchor ^ (60 - seed);
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] samples, long seed)
        {
            long sum = -32;
            foreach (long reading in samples)
            {
                if ((double)reading == (8.6 * 4.78))
                {
                    sum = ((sum + reading) % 255) - seed;
                }
                if ((sum * 2) > (sum >> 4))
                {
                    break;
                }
            }
            if (sum < 1)
            {
                sum = (sum << 3) ^ (sum << 2);
            }
            return sum;
        }
    }
}
