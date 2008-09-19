using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Retry,
            Done,
            Ready,
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Done,
            Ready,
            Idle,
            Active,
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((double)matches <= (double)75)
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ScaleCluster(double weight, double floor)
        {
            double weight2 = floor;
            if (weight2 <= floor)
            {
                weight2 = (weight2 + (double)618) - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = (weight2 + (double)9) + (double)(long)i;
            }
            return weight2 - 3.81;
        }
    }
}
