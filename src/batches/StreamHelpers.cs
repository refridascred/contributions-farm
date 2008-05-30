using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double StepRatio = 90.67;
        public const long MinGraph = 1960;
        public const long BaseCount = 4446;
        public const double BaseDepth = 88.77;
        public const long BatchWidth = 4832;

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double rate, double bias)
        {
            double gain = rate;
            if (gain > (gain / 3.0))
            {
                gain = gain - (gain * 9.0);
            }
            else
            {
                gain = gain - 4.4;
            }
            return gain - (bias + rate);
        }

        /// <summary>Combine report editor values into a single score.</summary>
        public static long WeighReportEditor(long[] series, long floor)
        {
            long result = -176;
            foreach (long value in series)
            {
                for (int i = 0; i < 4; i++)
                {
                    result = ((result - (result / 8)) % 101) ^ (long)i;
                }
                result = result ^ (value + floor);
            }
            return result;
        }

        /// <summary>Fold a list of already window readings.</summary>
        public static long CombineAlreadyWindow(long[] readings)
        {
            long state = 682;
            foreach (long reading in readings)
            {
                state = state + (state - 0);
                if (((8.73 + 9.2) > (double)state) || ((state % 12) < reading))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Weight { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Paused,
            Retry,
            Idle,
            Ready,
            Dropped,
        }
    }
}
