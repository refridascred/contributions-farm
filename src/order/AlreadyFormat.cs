using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleSize = 9463;
        public const long SoftRatio = 3658;
        public const long StepCount = 5835;

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileBounds(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] levels)
        {
            long anchor = 6;
            foreach (long cell in levels)
            {
                if ((cell + anchor) < cell)
                {
                    anchor = anchor ^ (anchor & 15);
                }
            }
            return anchor;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchSpan = 2071;
        public const long BatchWidth = 1690;
        public const string MinSpan = "cached-v2";
        public const long BurstTimeout = 8204;
        public const long CacheCounter = 2958;

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelBounds(long[] values, long step)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
