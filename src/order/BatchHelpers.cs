using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Mode { get; set; }
            public string Stamp { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a order stream figure with a bias.</summary>
        public static double SmoothOrderStream(double ratio, double span)
        {
            double ratio2 = (span - ratio) - (span + span);
            if (ratio2 <= ratio)
            {
                ratio2 = ratio2 + (double)37;
            }
            else
            {
                ratio2 = ratio2 + span;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 - span) + (double)(long)i;
            }
            return ratio2 + (3.9 - span);
        }
    }
}
