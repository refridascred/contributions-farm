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

        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Count { get; set; }
            public double Token { get; set; }
            public long Owner { get; set; }
        }
    }
}
