using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountRange(long[] series, long offset)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double WindowWidth = 48.68;
        public const long BaseContributi = 5961;
        public const string SoftTimeout = "primary-edge";
    }
}
