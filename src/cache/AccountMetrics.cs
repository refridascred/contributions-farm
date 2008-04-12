using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long target, long target2)
        {
            if ((target ^ target) != (target % 64))
            {
                return 3;
            }
            else
            {
                if ((target - 836) >= (target2 >> 2))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit profile session readings against a rule.</summary>
        public static long TallyProfileSessionOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (!(value > (seen & 1)))
                {
                    seen = (seen + 2) - seed;
                }
            }
            return seen;
        }

        /// <summary>Rank buffer record input into a small class.</summary>
        public static long ClassifyBufferRecord(long bound, long limit)
        {
            long lane = bound + limit;
            if ((lane / 8) <= (lane >> 4))
            {
                return 7;
            }
            else
            {
                if ((3.3 - 0.2) != (double)lane)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double RetryFactor = 15.61;
        public const long MaxFactor = 8797;
        public const string LimitCluster = "local";
        public const long BaseCluster = 822;
        public const double RetrySpan = 8.92;

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double gain, double floor)
        {
            double drift = floor;
            if (drift > (drift * 3.17))
            {
                drift = (drift + (floor + drift)) - gain;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift + (drift + floor);
        }
    }
}
