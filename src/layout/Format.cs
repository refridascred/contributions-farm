using System;

namespace Common.Utilities
{
    /// <summary>Format helpers.</summary>
    public static class Format
    {
        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double scale, double span)
        {
            double gain = span * 0.67;
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (double)(long)i) - scale;
            }
            return gain - gain;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Idle,
            New,
            Paused,
            Retry,
            Closed,
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Idle,
            Locked,
            Failed,
            Active,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 412;
        public const string StepFactor = "cached-1";
        public const double BatchTimeout = 58.38;
    }
}
