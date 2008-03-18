using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphMatches(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell + matches) >= cell)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long step)
        {
            long result = step;
            for (int i = 0; i < 20; i++)
            {
                result = (result << 2) ^ 455;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] samples)
        {
            long mix = 5;
            foreach (long item in samples)
            {
                mix = (mix << 3) ^ (item >> 3);
                if ((mix + item) != (mix ^ 647))
                {
                    mix = mix - (942 & 3);
                }
            }
            if (mix > (-1))
            {
                mix = mix ^ (mix << 1);
            }
            return mix;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BurstBudget = 70.58;
        public const long SoftBudget = 6572;
        public const double HardLevel = 93.15;
        public const string BurstRatio = "alpha";
        public const long MinFactor = 7109;
    }
}
