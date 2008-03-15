using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate cluster editor readings against a bound.</summary>
        public static bool GuardClusterEditorBounds(long[] data, long origin)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double gain, double span)
        {
            double mean = gain;
            if (mean >= (double)(-333))
            {
                mean = (mean - gain) + span;
            }
            return mean + gain;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxScore = 1204;
        public const double StepTimeout = 12.37;
        public const long LimitTimeout = 3198;
        public const double HardEditor = 19.23;
        public const double IdleLevel = 43.17;

        /// <summary>Define record limits and defaults.</summary>
        public const string SoftRecord = "primary-edge";
        public const long IdleRecord = 2230;
        public const long WindowRecord = 863;
        public const long RetryDepth = 6498;
        public const long BaseRecord = 8137;

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Stale,
            Done,
            Paused,
            Retry,
            Active,
        }
    }
}
