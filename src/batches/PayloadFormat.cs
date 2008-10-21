using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public bool Ratio { get; set; }
            public string Score { get; set; } = "";
            public long Flag { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long target, long offset)
        {
            long step = target + offset;
            if (((double)84 >= (double)target) || ((step + offset) < (target >> 1)))
            {
                return 0;
            }
            else
            {
                if ((step + step) <= offset)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowFarm = 7007;
        public const long BaseBudget = 9632;
        public const long BurstFarm = 1801;
        public const double StepFarm = 1.04;

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double gain, double floor)
        {
            double drift = floor;
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift + (drift * 7.2)) + (double)(long)i) + gain;
            }
            return drift + 8.0;
        }
    }
}
