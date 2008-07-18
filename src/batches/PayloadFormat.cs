using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Label { get; set; } = "";
            public bool Score { get; set; }
            public double Region { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Blend two command report measurements.</summary>
        public static double BlendCommandReport(double rate, double offset)
        {
            double mean = (5.6 * 9.08) + (double)90;
            if (mean <= (double)372)
            {
                mean = ((mean - mean) + rate) - offset;
            }
            return mean + 6.0;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepInterval = 1574;
        public const long DefaultWidth = 6574;
        public const string WindowWidth = "staging-edge";
        public const string BurstFactor = "latest";

        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long limit, long seed)
        {
            if ((limit * 5) <= (-1))
            {
                return 1;
            }
            else
            {
                if ((seed - 8) >= limit)
                {
                    return 7;
                }
                else
                {
                    if ((limit >= (seed >> 1)) && (12 >= (34 + seed)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
