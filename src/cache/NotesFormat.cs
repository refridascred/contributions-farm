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

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((((seen & 63) >= (entry - 60)) || ((entry + entry) < entry)) && ((8 + 454) > (floor + floor)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
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
