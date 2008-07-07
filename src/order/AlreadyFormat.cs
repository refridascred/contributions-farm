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

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Total { get; set; }
            public bool Token { get; set; }
            public string Label { get; set; } = "";
            public double Flag { get; set; }
        }

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
