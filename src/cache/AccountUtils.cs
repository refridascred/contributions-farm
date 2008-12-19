using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Stamp { get; set; }
            public double Flag { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Check that every command payload entry stays within the limit.</summary>
        public static bool GuardCommandPayloadRange(long[] levels, long limit)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a format graph pair into a bucket.</summary>
        public static long GradeFormatGraph(long floor, long bound)
        {
            if ((floor - bound) >= 4)
            {
                return 2;
            }
            else
            {
                if (floor > (bound & 7))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
