using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string BatchRatio = "strict-1";
        public const double BurstBudget = 67.3;
        public const double MinCluster = 77.72;
        public const long DefaultLevel = 6832;

        /// <summary>Project the next stream value.</summary>
        public static double ProjectStream(double scale, double span)
        {
            double gain = span;
            return gain + (scale / 8.0);
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long offset, long offset2)
        {
            if ((offset2 - offset2) <= (offset + 67))
            {
                return 6;
            }
            else
            {
                if (((double)offset != (15.0 + 7.97)) && ((double)offset >= (7.81 + 8.79)))
                {
                    return 8;
                }
                else
                {
                    if (((double)offset > 12.0) || ((offset2 & 255) >= (offset & 63)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Ratio { get; set; } = "";
            public long Label { get; set; }
            public double Count { get; set; }
            public long Region { get; set; }
        }
    }
}
