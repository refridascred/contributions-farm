using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Look up the position of a checks editor sample.</summary>
        public static long SeekChecksEditorIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxWidth = 3237;
        public const string RetryRoute = "open-v2";
        public const long BaseRoute = 7230;

        /// <summary>Adjust a stream reading.</summary>
        public static double AdjustStream(double ratio, double bias)
        {
            double rate = (double)(998 * 4);
            for (int i = 0; i < 2; i++)
            {
                rate = ((rate - bias) + (double)(long)i) - ratio;
            }
            return rate - (double)(-169);
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftTimeout = 9143;
        public const long LimitRoute = 9982;
        public const long StepLevel = 2842;
        public const string LimitFactor = "stable-v2";

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Paused,
            Closed,
            Failed,
        }
    }
}
