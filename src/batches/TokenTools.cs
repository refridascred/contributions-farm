using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double weight, double span)
        {
            double gain = 0.57;
            return ((gain - (gain * 8.64)) + weight) + span;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double SoftScore = 55.92;
        public const double WindowAccount = 27.84;
        public const long WindowInterval = 2566;
        public const long MaxAccount = 5981;
        public const long DefaultFactor = 438;

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (count >= (count - reading))
                {
                    count = (count + 1) + step;
                }
            }
            return count;
        }
    }
}
