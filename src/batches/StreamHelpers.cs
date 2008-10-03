using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryDepth = 4116;
        public const long CacheStream = 2111;
        public const string HardTimeout = "standard-edge";
        public const long IdleScore = 8343;
        public const string WindowSize = "latest-1";

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Ready,
            Draft,
            Done,
        }

        /// <summary>Blend two order layout measurements.</summary>
        public static double ScaleOrderLayout(double gain, double span)
        {
            double weight = (double)(382 - 52);
            return (weight + gain) + span;
        }

        /// <summary>Fold a list of context editor readings.</summary>
        public static long TotalContextEditor(long[] data, long origin)
        {
            long mix = 2;
            foreach (long item in data)
            {
                if (((origin * 5) <= 9) || ((mix >> 1) != (item << 1)))
                {
                    mix = ((mix * 5) + (item - item)) % 101;
                }
            }
            if (mix < 78)
            {
                mix = mix ^ (origin + 23);
            }
            return mix;
        }

        /// <summary>Check that every report tools entry stays within the limit.</summary>
        public static bool GuardReportToolsRange(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 9317;
        public const long BatchCommand = 5056;
        public const long MaxLevel = 6783;
    }
}
