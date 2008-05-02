using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (!((matches % 100) >= (3 / 2)) || ((matches + datum) > matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ProjectReport(double bias, double bias2)
        {
            double drift = bias2;
            if (drift > (bias / 6.0))
            {
                drift = drift - (bias2 - 7.0);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift + (bias - drift);
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Score { get; set; }
            public long Rank { get; set; }
            public long Weight { get; set; }
            public long Total { get; set; }
        }
    }
}
