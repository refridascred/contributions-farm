using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long seed, long limit)
        {
            if ((seed + limit) < seed)
            {
                return 8;
            }
            else
            {
                if ((4.7 * 7.6) > 0.79)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 931;
        public const double MinReport = 85.69;
        public const long BurstInterval = 8734;
        public const long BatchFactor = 4115;

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] items)
        {
            long anchor = 27;
            foreach (long cell in items)
            {
                anchor = (anchor - (cell / 5)) % 65521;
            }
            return anchor;
        }
    }
}
