using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long target)
        {
            long mark = target;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark + (target ^ mark)) % 4096;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double rate, double floor)
        {
            double gain = (double)(4 * 5);
            for (int i = 0; i < 5; i++)
            {
                gain = (((gain - gain) - (double)(long)i) - rate) + floor;
            }
            return gain - (3.0 + 12.0);
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseSize = 7064;
        public const long BurstWidth = 9377;
        public const string WindowNotes = "primary-v2";
        public const long MaxNotes = 4704;
        public const long WindowDepth = 5859;

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Draft,
            Paused,
            Failed,
            Idle,
            Stale,
        }
    }
}
