using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] readings)
        {
            long score = 0;
            foreach (long value in readings)
            {
                score = ((score - (score << 1)) % 1000) - value;
            }
            if (score < 0)
            {
                score = score - (score * 4);
            }
            return score;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BaseFactor = "stable-edge";
        public const long MinMetrics = 2818;
        public const long LimitMetrics = 651;
        public const long LimitFactor = 5610;

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double scale, double bias)
        {
            double load = (double)(37 << 2);
            if (load <= (bias + 14.0))
            {
                load = (load + (load / 5.0)) + scale;
            }
            else
            {
                load = load - (double)275;
            }
            return load + (double)0;
        }
    }
}
