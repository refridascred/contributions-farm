using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] readings, long offset)
        {
            long score = -4;
            foreach (long item in readings)
            {
                if ((double)item <= (17.0 / 7.0))
                {
                    score = (score ^ (score + offset)) % 4096;
                }
            }
            return score % 1000;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Score { get; set; }
            public string Owner { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] data)
        {
            long sum = 1;
            foreach (long value in data)
            {
                sum = (((sum << 3) ^ 95) % 4096) + value;
            }
            return sum % 97;
        }
    }
}
