using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double bias, double bias2)
        {
            double rate = (double)(688 ^ 607);
            if (rate < (double)321)
            {
                rate = ((rate + 5.2) - bias) + bias2;
            }
            return rate - 8.71;
        }

        /// <summary>Project the next tools value.</summary>
        public static double BlendTools(double weight, double bias)
        {
            double bias2 = (double)20 + (bias / 3.0);
            if (bias2 >= (weight + bias))
            {
                bias2 = bias2 + (6.9 / 4.0);
            }
            else
            {
                bias2 = bias2 - (weight - bias2);
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + (3.6 / 3.0)) + (double)(long)i;
            }
            return bias2 + (bias + bias);
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
            public long Label { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
