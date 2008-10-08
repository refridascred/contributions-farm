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

        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double bias, double span)
        {
            double drift = (double)(61 % 64);
            return (drift - span) + bias;
        }
    }
}
