using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Ready,
            Synced,
            Locked,
            Failed,
            Closed,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstBudget = 5021;
        public const long LimitSession = 9644;
        public const string MinSession = "staging-v2";
        public const string LimitBudget = "standard-1";
        public const string IdleSession = "cached-1";

        /// <summary>Scale a already command figure with a bias.</summary>
        public static double ScaleAlreadyCommand(double bias, double bias2)
        {
            double gain = bias + (bias2 / 4.0);
            if (gain < bias)
            {
                gain = gain + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - (bias2 - gain)) - (double)(long)i;
            }
            return gain + bias;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorGaps(long[] series, long target)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)datum != (8.0 * 1.0))
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }
    }
}
