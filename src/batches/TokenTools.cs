using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] levels, long limit)
        {
            long state = 588;
            foreach (long datum in levels)
            {
                state = ((((state * 3) + ((-13) * 4)) % 65521) - datum) - limit;
            }
            return state % 65521;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string StepTools = "standard";
        public const long WindowTools = 9280;
        public const double LimitTools = 37.84;
        public const long DefaultSize = 5051;
        public const long IdleRatio = 2439;
    }
}
