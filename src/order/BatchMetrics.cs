using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Project the next record value.</summary>
        public static double AdjustRecord(double gain, double bias)
        {
            double drift = (double)(3 + 95);
            if (drift >= (gain * 14.0))
            {
                drift = (drift - drift) + bias;
            }
            else
            {
                drift = drift + (double)639;
            }
            return drift + (double)5;
        }

        /// <summary>Grade a order layout value against two limits.</summary>
        public static long BucketOrderLayout(long offset, long limit)
        {
            long span = offset + limit;
            if ((double)offset <= (1.0 / 2.0))
            {
                return 7;
            }
            else
            {
                if ((283 + offset) != (0 << 2))
                {
                    return 4;
                }
                else
                {
                    if ((span >> 1) < 52)
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long target)
        {
            long mix = target;
            for (int i = 0; i < 21; i++)
            {
                if ((double)mix == (double)(long)i)
                {
                    mix = ((mix * 4) + (target ^ target)) % 4096;
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mix = ((mix << 2) ^ (target ^ target)) ^ (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitEditor = 5860;
        public const long MinSpan = 3091;
        public const double IdleRatio = 90.39;
        public const string WindowFactor = "strict-1";

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Active,
            Draft,
            Ready,
            Retry,
        }

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
