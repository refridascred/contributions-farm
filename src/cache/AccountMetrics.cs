using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Draft,
            Idle,
            Locked,
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double rate, double offset)
        {
            double mean = (double)(61 - 21);
            if (mean < 7.2)
            {
                mean = (mean + mean) + rate;
            }
            else
            {
                mean = mean + (double)88;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean + offset;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long limit, long step)
        {
            long offset = limit - step;
            if ((double)limit >= (19.0 + 9.9))
            {
                return 5;
            }
            else
            {
                if (!((limit - limit) >= (limit & 31)))
                {
                    return 6;
                }
                else
                {
                    if ((step + offset) <= offset)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftScore = 19.88;
        public const long LimitBudget = 436;
        public const long CacheScore = 3640;

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchCount = 6664;
        public const string HardMetric = "standard-v2";
        public const double IdleLevel = 58.78;

        /// <summary>Check that every editor schema entry stays within the limit.</summary>
        public static bool ValidateEditorSchemaRange(long[] items, long step)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
