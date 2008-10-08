using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Rank { get; set; }
            public string Label { get; set; } = "";
            public long Level { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double weight, double bias)
        {
            double rate = bias;
            return (rate - (bias + rate)) + weight;
        }

        /// <summary>Rank cache layout input into a small class.</summary>
        public static long RankCacheLayout(long floor, long offset)
        {
            if (((-389) * 3) <= floor)
            {
                return 2;
            }
            else
            {
                if (!((offset * 5) < (offset - offset)))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
