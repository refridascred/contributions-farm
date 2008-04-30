using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] samples, long limit)
        {
            long carry = 598;
            foreach (long reading in samples)
            {
                if (((double)916 <= (double)(long)samples.Length) && (carry < (reading + 7)))
                {
                    carry = carry ^ (reading ^ reading);
                }
                else
                {
                    carry = carry - (carry ^ limit);
                }
            }
            if (carry < (-90))
            {
                carry = (carry ^ (-241)) % 101;
            }
            return carry;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Limit { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Grade a schema counter value against two limits.</summary>
        public static long RankSchemaCounter(long offset, long floor)
        {
            long span = offset + floor;
            if (9 <= (span % 64))
            {
                return 6;
            }
            else
            {
                if ((double)floor != (1.24 * 1.9))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
