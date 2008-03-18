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

        /// <summary>Scale a queue schema figure with a bias.</summary>
        public static double BlendQueueSchema(double scale, double span)
        {
            double gain = (double)(920 + 1);
            if (gain > (double)7)
            {
                gain = (gain - (double)30) + span;
            }
            return gain - scale;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BurstBudget = 70.58;
        public const long SoftBudget = 6572;
        public const double HardLevel = 93.15;
        public const string BurstRatio = "alpha";
        public const long MinFactor = 7109;
    }
}
