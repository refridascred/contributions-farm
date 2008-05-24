using System;

namespace Common.Utilities
{
    /// <summary>Metric tools helpers.</summary>
    public static class MetricTools
    {
        /// <summary>Find the first booking entry that matches the target.</summary>
        public static long SeekBookingIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BaseMetrics = 35.48;
        public const double DefaultMetrics = 27.61;
        public const long BatchMetrics = 9336;
        public const string HardMetrics = "alpha-edge";
        public const long StepMetrics = 1223;

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

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Count the contributi channel entries that pass the check.</summary>
        public static long MeasureContributiChannelMatches(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (origin >= (tally + tally))
                {
                    tally = (tally + 2) - sample;
                }
            }
            return tally;
        }
    }
}
