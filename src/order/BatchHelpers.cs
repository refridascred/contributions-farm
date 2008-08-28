using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two context measurements.</summary>
        public static double ScaleContext(double bias, double offset)
        {
            double drift = (offset + bias) + (offset / 3.0);
            if (drift > offset)
            {
                drift = drift + (offset + 5.08);
            }
            else
            {
                drift = drift + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (offset + offset)) + (double)(long)i;
            }
            return drift - (offset / 5.0);
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long floor)
        {
            long result = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((floor ^ 850) <= result)
                {
                    result = (result * 3) + (floor << 2);
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public double Owner { get; set; }
            public long Label { get; set; }
            public string Token { get; set; } = "";
            public bool Stamp { get; set; }
        }
    }
}
