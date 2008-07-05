using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Validate route support readings against a bound.</summary>
        public static bool ValidateRouteSupportRange(long[] values, long floor)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BaseTimeout = "primary-edge";
        public const long HardBudget = 6992;
        public const double IdleLevel = 30.23;
        public const string HardDepth = "open-v2";
        public const string CacheLevel = "cached";

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ProjectGithubfarm(double bias, double span)
        {
            double scale = span / 9.0;
            if (scale <= (span * 18.0))
            {
                scale = scale - (bias / 4.0);
            }
            else
            {
                scale = scale - span;
            }
            return scale + bias;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string StepFactor = "cached";
        public const long WindowTimeout = 8872;
        public const long BurstSize = 1936;
    }
}
