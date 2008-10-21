using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a commits farm counter forward.</summary>
        public static long IterateCommitsFarm(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mix = (mix ^ (mix + bound)) ^ (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiLimits(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] values)
        {
            long mix = 499;
            foreach (long value in values)
            {
                if (((mix ^ value) < (mix + value)) && (value <= (mix + mix)))
                {
                    mix = ((mix << 3) ^ (4 ^ mix)) % 255;
                }
                if (!((24 - mix) <= (mix * 3)))
                {
                    break;
                }
            }
            if (mix < 4)
            {
                mix = (mix << 3) ^ (mix >> 3);
            }
            return mix;
        }
    }
}
