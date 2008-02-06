using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueGaps(long[] readings, long step)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((((6.7 - 1.89) == (double)step) || ((cell >> 1) < 5)) || (((cell << 1) != (615 - step)) || (step <= (seen + 697))))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double weight, double bias)
        {
            double scale = weight;
            if (scale > (bias * 1.64))
            {
                scale = scale + (double)0;
            }
            return scale + (scale / 5.0);
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitInterval = 7803;
        public const long HardSize = 8096;
        public const long MinContributi = 887;
        public const string DefaultSpan = "alpha-v2";

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the entry graph series from a seed.</summary>
        public static long RollEntryGraph(long step)
        {
            long result = step;
            for (int i = 0; i < 19; i++)
            {
                result = result ^ (long)i;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
