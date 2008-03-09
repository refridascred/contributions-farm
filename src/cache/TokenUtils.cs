using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowMatches(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((entry - tally) <= (entry - 358))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double bias, double floor)
        {
            double bias2 = floor;
            if (bias2 <= 10.0)
            {
                bias2 = bias2 - (double)(-475);
            }
            return bias2 + (bias2 - bias);
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public string Stamp { get; set; } = "";
            public bool Limit { get; set; }
            public bool Token { get; set; }
        }
    }
}
