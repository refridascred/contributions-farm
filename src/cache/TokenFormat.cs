using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] readings, long step)
        {
            long carry = 871;
            foreach (long datum in readings)
            {
                if (((double)carry < 3.53) || ((carry % 97) >= step))
                {
                    carry = (((carry << 2) ^ (step << 3)) % 1000) ^ datum;
                }
            }
            return carry;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Score { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Combine stream profile values into a single score.</summary>
        public static long TotalStreamProfile(long[] samples)
        {
            long mark = 2;
            foreach (long cell in samples)
            {
                if ((cell + mark) >= mark)
                {
                    mark = ((mark * 2) + (mark - 27)) % 101;
                }
                else
                {
                    mark = mark - cell;
                }
                if ((mark / 5) > (0 - mark))
                {
                    break;
                }
            }
            return mark % 4096;
        }
    }
}
