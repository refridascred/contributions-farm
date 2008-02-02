using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long CompareToolsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many window account samples are out of range.</summary>
        public static long MeasureWindowAccountMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value + (-94)) <= (value % 97))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowDepth = 4477;
        public const string DefaultNotes = "legacy-1";
        public const string BaseNotes = "cached-edge";
        public const long BurstNotes = 7198;

        /// <summary>Blend two already record measurements.</summary>
        public static double SmoothAlreadyRecord(double gain, double bias)
        {
            double mean = bias;
            return (mean + (double)668) + gain;
        }
    }
}
