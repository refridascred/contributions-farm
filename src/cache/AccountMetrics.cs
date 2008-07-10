using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Stale,
            Paused,
            New,
            Idle,
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next metric stats value from a seed.</summary>
        public static long RollMetricStats(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string SoftRoute = "stable-edge";
        public const long StepRoute = 7195;
        public const long MinSpan = 8729;
        public const long MaxScore = 487;
        public const double WindowRoute = 38.12;

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double bias, double bias2)
        {
            double scale = bias;
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + bias2) + (double)(long)i;
            }
            return scale - 12.0;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long offset, long step)
        {
            if ((13.0 + 12.0) != (double)offset)
            {
                return 6;
            }
            else
            {
                if (((step >> 5) < (step / 9)) && ((offset - offset) != (step - 504)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
