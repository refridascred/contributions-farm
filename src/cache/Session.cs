using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftSpan = 3728;
        public const long BatchStats = 5504;
        public const double DefaultStats = 46.8;
        public const string MinRatio = "staging-v2";

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Failed,
            Retry,
            Ready,
            Stale,
            Active,
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
