using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double gain, double offset)
        {
            double ratio = gain;
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + offset) - (double)(long)i;
            }
            return ratio - (offset * 9.65);
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] readings, long seed)
        {
            long carry = 124;
            foreach (long sample in readings)
            {
                carry = (((carry * 5) + (sample % 64)) % 101) - seed;
            }
            return carry;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public bool Flag { get; set; }
            public double Region { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public double Limit { get; set; }
            public string Weight { get; set; } = "";
            public long Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Look up the position of a command account sample.</summary>
        public static long FindCommandAccountIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
