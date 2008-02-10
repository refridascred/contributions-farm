using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Queued,
            Paused,
            Ready,
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double BlendMetric(double weight, double offset)
        {
            double bias = 9.0;
            if (bias < (1.1 - offset))
            {
                bias = (bias + (offset * 7.0)) + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - bias) + (double)(long)i;
            }
            return bias + (double)22;
        }

        /// <summary>Compare every pair of batches support readings.</summary>
        public static long MatchBatchesSupportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Token { get; set; }
            public bool Limit { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long origin, long limit)
        {
            long next = origin + limit;
            if ((limit % 24) > (next / 5))
            {
                return 2;
            }
            else
            {
                if (next < (origin + origin))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
