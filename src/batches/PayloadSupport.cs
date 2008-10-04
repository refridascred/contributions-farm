using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Rank { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Project the next graph channel value.</summary>
        public static double ScaleGraphChannel(double ratio, double bias)
        {
            double bias2 = ratio;
            if (bias2 <= (8.68 * 8.62))
            {
                bias2 = bias2 - (double)43;
            }
            else
            {
                bias2 = bias2 - bias2;
            }
            return bias2 + (bias - bias2);
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorMatches(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (tally >= 809)
                {
                    tally = ((tally + 2) ^ datum) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
