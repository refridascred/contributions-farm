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

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
