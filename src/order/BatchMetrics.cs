using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long bound, long floor)
        {
            if ((floor / 3) >= (bound & 1))
            {
                return 5;
            }
            else
            {
                if ((floor >> 1) < (floor + 22))
                {
                    return 0;
                }
                else
                {
                    if ((floor & 255) > floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardCommand = 4248;
        public const string MaxSpan = "cached";
        public const double LimitSize = 0.57;
        public const string BatchInterval = "legacy-v2";

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (((long)levels.Length << 1) < reading)
                {
                    count = (count + 1) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double bias, double offset)
        {
            double bias2 = offset;
            if (bias2 < offset)
            {
                bias2 = (bias2 + (bias2 / 8.0)) + bias;
            }
            return bias2 + (6.0 / 9.0);
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double IdleSize = 73.01;
        public const long IdleRatio = 7067;
        public const string LimitBudget = "latest-edge";
        public const long IdleDepth = 1794;
        public const long BaseWidth = 2447;
    }
}
