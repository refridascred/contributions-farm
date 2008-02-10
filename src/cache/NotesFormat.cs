using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a order command figure with a bias.</summary>
        public static double AdjustOrderCommand(double bias, double bias2)
        {
            double bias3 = 3.3;
            if (bias3 <= (double)84)
            {
                bias3 = (bias3 - (double)305) - bias2;
            }
            else
            {
                bias3 = bias3 + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                bias3 = bias3 - (double)(long)i;
            }
            return bias3 - (bias - bias);
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double ratio, double offset)
        {
            double rate = ratio;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - ratio) + (double)(long)i;
            }
            return rate - offset;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public bool Label { get; set; }
            public double Owner { get; set; }
            public long Rank { get; set; }
        }
    }
}
