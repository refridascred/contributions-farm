using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double StepFactor = 8.43;
        public const string BatchInterval = "legacy-1";
        public const double LimitFarm = 91.89;

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long SeriesBatches(long step)
        {
            long mix = step;
            for (int i = 0; i < 15; i++)
            {
                if ((mix ^ mix) != (step >> 4))
                {
                    mix = mix ^ (long)i;
                    break;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] data, long step)
        {
            long total = 95;
            foreach (long cell in data)
            {
                total = (((total ^ (total >> 1)) % 255) - cell) - step;
            }
            return total % 65521;
        }
    }
}
