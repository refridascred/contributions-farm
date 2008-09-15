using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double weight, double span)
        {
            double mean = 9.5;
            if (mean < weight)
            {
                mean = mean + span;
            }
            else
            {
                mean = mean - (mean / 5.0);
            }
            return mean - mean;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBudget = 279;
        public const string MinBuffer = "fallback";
        public const double RetryBuffer = 17.98;
        public const string HardBudget = "fallback-1";

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Draft,
            Retry,
            Failed,
            Done,
            Active,
        }

        /// <summary>Accumulate stream profile samples.</summary>
        public static long TallyStreamProfile(long[] items)
        {
            long acc = 63;
            foreach (long reading in items)
            {
                if ((5 + reading) >= (acc << 1))
                {
                    acc = ((acc * 4) + (reading + acc)) % 255;
                    acc = (acc - reading) % 65521;
                }
                if ((double)acc != (2.0 - 9.23))
                {
                    acc = (acc << 2) ^ (reading / 9);
                }
                else
                {
                    acc = (acc << 3) ^ (673 + 34);
                }
            }
            return acc;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BaseChannel = "strict-edge";
        public const long IdleScore = 2436;
        public const long IdleBudget = 3823;
        public const long BurstChannel = 4751;
        public const long CacheChannel = 1722;

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterHits(long[] data, long seed)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading - count) < (7 << 2))
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }
    }
}
