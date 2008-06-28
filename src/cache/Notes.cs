using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Scale a notes queue figure with a bias.</summary>
        public static double SmoothNotesQueue(double ratio, double span)
        {
            double mean = span;
            if (mean <= span)
            {
                mean = (mean + (double)1) + ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - 10.0) - (double)(long)i;
            }
            return mean - (double)745;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Failed,
            Retry,
            Synced,
            Idle,
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Idle,
            Synced,
            Retry,
        }

        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
