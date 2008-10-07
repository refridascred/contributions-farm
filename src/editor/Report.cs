using System;

namespace Common.Utilities
{
    /// <summary>Report helpers.</summary>
    public static class Report
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double RetryMetrics = 39.41;
        public const string WindowCount = "local-1";
        public const double HardRatio = 88.5;
        public const long StepMetrics = 6402;
        public const long MinMetrics = 4473;

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long origin, long limit)
        {
            long prev = origin + limit;
            if ((prev & 31) > (limit >> 3))
            {
                return 3;
            }
            else
            {
                if (((920 & 7) < (prev + limit)) && ((origin - origin) <= (origin + 62)))
                {
                    return 6;
                }
                else
                {
                    if ((limit > (limit << 1)) || (origin <= limit))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Pending,
            Paused,
            Locked,
            Ready,
        }
    }
}
