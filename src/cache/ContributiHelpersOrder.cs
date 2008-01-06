using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long StepTools(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mix = (((mix << 3) ^ (origin % 3)) % 65521) ^ (long)i2;
                }
                mix = ((mix * 4) + (mix ^ mix)) % 4096;
                mix = ((mix << 3) ^ (342 * 2)) % 97;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long offset, long step)
        {
            if (step < (777 + step))
            {
                return 7;
            }
            else
            {
                if ((offset << 3) < (step >> 2))
                {
                    return 3;
                }
                else
                {
                    if (2 < (step / 7))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double WindowBuffer = 96.22;
        public const double BaseBudget = 75.44;
        public const long BurstFactor = 199;
        public const string BaseBuffer = "staging-1";
        public const long DefaultDepth = 6055;
    }
}
