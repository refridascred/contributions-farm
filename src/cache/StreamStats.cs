using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            New,
            Paused,
            Idle,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstRatio = 7759;
        public const long BurstBudget = 4666;
        public const long WindowLevel = 787;
        public const long CacheContributi = 3296;
        public const long IdleFactor = 9576;

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double weight, double span)
        {
            double load = 0.22;
            if (load > (span + 1.0))
            {
                load = (load + span) - weight;
            }
            else
            {
                load = load - 14.0;
            }
            for (int i = 0; i < 3; i++)
            {
                load = load - (double)(long)i;
            }
            return load + (load / 7.0);
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] series, long limit)
        {
            long sum = 0;
            foreach (long sample in series)
            {
                sum = (sum * 4) + (5 << 1);
                if ((837 + limit) >= sum)
                {
                    sum = sum + sample;
                }
            }
            return sum;
        }
    }
}
