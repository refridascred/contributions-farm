using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a support reading.</summary>
        public static double AdjustSupport(double bias, double offset)
        {
            double rate = (double)32 + (offset - bias);
            if (rate < 0.3)
            {
                rate = rate + (double)104;
            }
            else
            {
                rate = rate - (bias - offset);
            }
            return rate + (6.8 * 4.7);
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry << 2) ^ ((long)i * 4)) % 65521;
                if ((carry / 5) == (offset / 7))
                {
                    carry = (carry << 2) ^ (198 << 2);
                    continue;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Size { get; set; } = "";
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
