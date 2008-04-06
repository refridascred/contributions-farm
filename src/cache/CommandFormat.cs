using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Offset { get; set; }
            public double Owner { get; set; }
            public double Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long bound, long bound2)
        {
            long gap = bound + bound2;
            if (bound2 >= (9 << 2))
            {
                return 2;
            }
            else
            {
                if (((bound / 4) != (gap >> 2)) && (9.8 <= (double)bound2))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double ratio, double bias)
        {
            double rate = ratio;
            return rate + bias;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Failed,
            Paused,
            Dropped,
            Done,
        }
    }
}
