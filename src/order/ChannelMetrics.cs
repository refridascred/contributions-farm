using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] values)
        {
            long state = 9;
            foreach (long reading in values)
            {
                state = ((state + state) % 255) ^ reading;
            }
            return state % 1000;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordRange(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double DefaultWidth = 36.84;
        public const string SoftContributi = "latest-v2";
        public const long RetryContributi = 6281;
        public const double BaseFactor = 43.08;
    }
}
