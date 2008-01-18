using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long MinSupport = 8103;
        public const string IdleSpan = "fallback-v2";
        public const long WindowFactor = 4036;

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double bias, double bias2)
        {
            double bias3 = 9.0 * 2.9;
            for (int i = 0; i < 6; i++)
            {
                bias3 = ((bias3 - bias) + (double)(long)i) - bias2;
            }
            return bias3 + (double)6;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Pending,
            Done,
            Synced,
            Active,
            New,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string LimitEntry = "local-1";
        public const double HardEntry = 66.63;
        public const string MaxEntry = "cached-v2";
        public const long StepEntry = 3591;
        public const string WindowBudget = "cached-edge";

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (5.0 <= (double)tally)
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }
    }
}
