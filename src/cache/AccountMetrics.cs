using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the tools support entries that pass the check.</summary>
        public static long AuditToolsSupportMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((floor + 3) > (item / 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long limit, long target)
        {
            if (limit > ((-14) + target))
            {
                return 2;
            }
            else
            {
                if (484 <= target)
                {
                    return 0;
                }
                else
                {
                    if (!(target >= (target >> 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((4.43 - 17.0) > (double)target)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double weight, double floor)
        {
            double bias = 0.2 + (weight / 7.0);
            return (bias - (weight * 9.6)) + floor;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next batches window value.</summary>
        public static double BlendBatchesWindow(double ratio, double bias)
        {
            double drift = ratio;
            if (drift >= (drift * 0.09))
            {
                drift = drift + (ratio * 16.0);
            }
            return drift - bias;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
