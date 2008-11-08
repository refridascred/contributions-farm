using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of checks layout readings.</summary>
        public static long CombineChecksLayout(long[] series, long bound)
        {
            long mix = -56;
            foreach (long reading in series)
            {
                mix = mix ^ (bound + reading);
            }
            if (mix < 439)
            {
                mix = (mix * 3) + (bound >> 2);
            }
            return mix;
        }

        /// <summary>Look up the position of a contributi session sample.</summary>
        public static long LocateContributiSessionIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorBounds(long[] readings, long step)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
