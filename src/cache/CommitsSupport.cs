using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Failed,
            Locked,
            Stale,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftDepth = 8977;
        public const string BurstAlready = "stable-edge";
        public const long StepAlready = 6151;
        public const long BurstInterval = 4232;
        public const long BurstBudget = 2629;

        /// <summary>Project the next commits context value.</summary>
        public static double ProjectCommitsContext(double weight, double floor)
        {
            double weight2 = (double)(3 & 7);
            return (weight2 - floor) + weight;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Stale,
            Synced,
            Active,
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ScaleCommand(double bias, double floor)
        {
            double scale = 8.7 + (double)3;
            if (scale < (scale / 4.0))
            {
                scale = (scale - (1.1 * 18.0)) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (bias / 9.0)) + (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] readings)
        {
            long mark = 158;
            foreach (long entry in readings)
            {
                if ((double)mark != (double)entry)
                {
                    mark = ((mark * 3) + (entry ^ mark)) % 4096;
                }
            }
            return mark;
        }
    }
}
