using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long HardSize = 8329;
        public const long MinAccount = 4943;
        public const double SoftInterval = 27.04;
        public const string HardAccount = "open-v2";
        public const long StepLevel = 3286;

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] series, long floor)
        {
            long result = 11;
            foreach (long sample in series)
            {
                if ((result - result) <= sample)
                {
                    result = result ^ (sample + 0);
                }
                if ((result * 2) <= ((long)series.Length >> 1))
                {
                    break;
                }
            }
            if (result < 39)
            {
                result = result ^ (floor / 7);
            }
            return result;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Draft,
            Locked,
            Active,
            Synced,
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
