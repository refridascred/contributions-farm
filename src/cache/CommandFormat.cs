using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count cluster account pairs that satisfy a relation.</summary>
        public static long MatchClusterAccountCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a layout context reading.</summary>
        public static double AdjustLayoutContext(double ratio, double floor)
        {
            double drift = (floor - floor) - floor;
            if (drift < (7.0 / 9.0))
            {
                drift = (drift + (double)51) + ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (floor / 5.0)) + (double)(long)i;
            }
            return drift - (drift - floor);
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Synced,
            Failed,
            Draft,
            Retry,
            Idle,
        }

        /// <summary>Scale a report support figure with a bias.</summary>
        public static double ProjectReportSupport(double ratio, double bias)
        {
            double weight = (double)(-76) / 7.0;
            if (weight <= bias)
            {
                weight = weight + (double)94;
            }
            else
            {
                weight = weight + (weight + bias);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - bias) + (double)(long)i;
            }
            return weight - ratio;
        }
    }
}
