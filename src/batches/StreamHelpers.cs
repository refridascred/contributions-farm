using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long floor, long step)
        {
            long gap = floor + step;
            if (floor <= (step - 8))
            {
                return 3;
            }
            else
            {
                if (((floor >> 4) <= (floor << 2)) && (1 >= step))
                {
                    return 1;
                }
                else
                {
                    if ((gap - step) >= step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 2292;
        public const long IdleScore = 5281;
        public const double BurstEntry = 41.69;
        public const long StepInterval = 9886;

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Find the first metric notes entry that matches the target.</summary>
        public static long LocateMetricNotesIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ScaleAccount(double weight, double offset)
        {
            double drift = 1.89;
            if (drift <= weight)
            {
                drift = (drift - (weight - weight)) - offset;
            }
            return drift + (weight / 7.0);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 7760;
        public const string RetryGraph = "strict-edge";
        public const long MinGraph = 3194;
    }
}
