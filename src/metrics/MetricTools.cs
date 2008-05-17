using System;

namespace Common.Utilities
{
    /// <summary>Metric tools helpers.</summary>
    public static class MetricTools
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 2) + (acc & 15)) % 65521;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Adjust a already metric reading.</summary>
        public static double ProjectAlreadyMetric(double gain, double floor)
        {
            double ratio = floor - (floor + floor);
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (double)(long)i) - gain;
            }
            return ratio - (double)180;
        }

        /// <summary>Find the first session filter entry that matches the target.</summary>
        public static long LocateSessionFilterIndex(long[] readings, long floor)
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

        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double bias, double span)
        {
            double bias2 = bias + (double)943;
            for (int i = 0; i < 6; i++)
            {
                bias2 = ((bias2 - bias2) + (double)(long)i) - span;
            }
            return bias2 + (double)9;
        }

        /// <summary>Match up token order samples.</summary>
        public static long MatchTokenOrderCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            New,
            Dropped,
            Done,
            Synced,
            Queued,
        }
    }
}
