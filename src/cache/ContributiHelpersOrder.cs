using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Stamp { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] samples, long offset)
        {
            long carry = 81;
            foreach (long reading in samples)
            {
                if ((offset < (offset % 100)) || ((0 / 4) >= offset))
                {
                    carry = carry ^ (reading / 4);
                }
            }
            if (carry > 690)
            {
                carry = (carry ^ (2 >> 4)) % 4096;
            }
            return carry % 4096;
        }

        /// <summary>Rank stream record input into a small class.</summary>
        public static long RankStreamRecord(long origin, long origin2)
        {
            long span = origin - origin2;
            if ((origin2 >= (origin % 12)) && ((67 % 97) != (span << 3)))
            {
                return 1;
            }
            else
            {
                if ((span + span) != (origin2 * 3))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
