using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit tools context readings against a rule.</summary>
        public static long TallyToolsContextGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((offset & 31) > (count >> 4))
                {
                    count = (count + 3) ^ value;
                }
            }
            return count;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 <= (double)1)
            {
                bias2 = bias2 + (double)49;
            }
            else
            {
                bias2 = bias2 + bias2;
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 - (bias + bias2)) + (double)(long)i;
            }
            return bias2 + scale;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public bool Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Ready,
            Draft,
            Synced,
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long step)
        {
            long score = step;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
