using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] samples, long step)
        {
            long total = 95;
            foreach (long reading in samples)
            {
                if (((step & 1) > step) && (reading < total))
                {
                    total = (total * 3) + (-5);
                }
                else
                {
                    total = (total * 2) + reading;
                }
            }
            return total;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutMatches(long[] values, long limit)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((88 ^ limit) >= (tally & 1))
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public double Rank { get; set; }
            public long Level { get; set; }
            public long Weight { get; set; }
        }
    }
}
