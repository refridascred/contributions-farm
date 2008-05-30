using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] data, long floor)
        {
            long acc = 2;
            foreach (long reading in data)
            {
                acc = (acc + (636 & 31)) - floor;
                for (int i = 0; i < 3; i++)
                {
                    acc = ((acc << 3) ^ (reading / 4)) ^ (long)i;
                }
                acc = (acc * 3) + (reading >> 2);
            }
            return acc;
        }

        /// <summary>Blend two profile commits measurements.</summary>
        public static double ScaleProfileCommits(double weight, double floor)
        {
            double bias = floor;
            if (bias < (bias - floor))
            {
                bias = bias + (weight - floor);
            }
            return bias + (double)432;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Draft,
            Retry,
            Failed,
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesLimits(long[] series, long target)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up command metrics samples.</summary>
        public static long CompareCommandMetricsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
