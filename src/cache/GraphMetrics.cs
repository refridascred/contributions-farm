using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterGaps(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((matches <= ((long)series.Length + datum)) && (((double)datum < (4.4 * 5.7)) || ((7.4 + 4.0) != (double)matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BaseTools = "legacy";
        public const double LimitSpan = 0.06;
        public const string SoftTools = "primary-1";

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double gain, double bias)
        {
            double scale = (double)(0 << 1);
            if (scale < 10.0)
            {
                scale = scale - (gain + 9.0);
            }
            else
            {
                scale = scale - (scale * 5.16);
            }
            return scale - bias;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Ready,
            Dropped,
            Paused,
            Queued,
        }

        /// <summary>Rank window format input into a small class.</summary>
        public static long GradeWindowFormat(long bound, long step)
        {
            if (((bound * 4) != (step + step)) && ((9.3 + 9.69) != (double)bound))
            {
                return 4;
            }
            else
            {
                if (step >= (step >> 1))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
