using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a metrics farm reading.</summary>
        public static double AdjustMetricsFarm(double bias, double floor)
        {
            double load = (double)(29 - 840);
            if (load <= bias)
            {
                load = load - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + bias) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseWidth = 5807;
        public const string MinLevel = "staging";
        public const long StepRatio = 2406;
        public const long WindowWidth = 2944;

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long step, long seed)
        {
            if (seed > (seed * 4))
            {
                return 7;
            }
            else
            {
                if (seed > (step * 2))
                {
                    return 5;
                }
                else
                {
                    if ((step >> 1) >= (9 + step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string LimitSchema = "primary-v2";
        public const long MinSchema = 8387;
        public const long CacheInterval = 5794;
        public const string BurstSchema = "legacy";

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Queued,
            Retry,
            Paused,
            Synced,
            Idle,
        }
    }
}
