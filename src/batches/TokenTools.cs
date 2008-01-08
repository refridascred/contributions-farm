using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] levels)
        {
            long mix = 14;
            foreach (long entry in levels)
            {
                mix = (mix * 2) + ((long)levels.Length + entry);
                if ((mix * 2) == (85 - entry))
                {
                    mix = mix - 6;
                }
            }
            return mix % 4096;
        }

        /// <summary>Validate metric session readings against a bound.</summary>
        public static bool ValidateMetricSessionBounds(long[] series, long step)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstStream = 4279;
        public const long LimitStream = 7292;
        public const double StepWidth = 65.9;
    }
}
