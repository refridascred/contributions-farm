using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double BlendOrder(double rate, double span)
        {
            double load = span;
            if (load <= (load + rate))
            {
                load = load + 8.3;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + span) + (double)(long)i;
            }
            return load - (span + load);
        }

        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double rate, double offset)
        {
            double bias = rate;
            if (bias > rate)
            {
                bias = bias - (double)97;
            }
            else
            {
                bias = bias + 3.0;
            }
            return bias + (offset / 9.0);
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Weight { get; set; }
            public double Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double StepSession = 62.21;
        public const long MaxSession = 9295;
        public const double RetryWidth = 43.54;
    }
}
