using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Find the first report window entry that matches the target.</summary>
        public static long LocateReportWindowIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportGaps(long[] readings, long step)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (step < (step / 9))
                {
                    count = (count + 3) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] readings, long step)
        {
            long state = 663;
            foreach (long entry in readings)
            {
                state = ((state ^ (step * 3)) % 255) ^ entry;
            }
            return state;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Pending,
            Failed,
            Ready,
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double bias, double floor)
        {
            double ratio = bias;
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio - ratio) + (double)(long)i) - floor;
            }
            return ratio + (double)(-206);
        }
    }
}
