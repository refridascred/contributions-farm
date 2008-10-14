using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BurstCount = "stable-edge";
        public const long MinScore = 8117;
        public const long HardAlready = 6844;
        public const string CacheAlready = "strict-v2";
        public const string StepAlready = "cached-edge";

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a stream filter reading.</summary>
        public static double ScaleStreamFilter(double weight, double offset)
        {
            double mean = 15.0;
            if (mean >= (double)977)
            {
                mean = mean + (double)2;
            }
            else
            {
                mean = mean - (weight + 3.6);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + offset) - (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Synced,
            Draft,
            Locked,
            Stale,
            Active,
        }
    }
}
