using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a layout buffer counter forward.</summary>
        public static long RollLayoutBuffer(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    acc = (((acc * 3) + (acc % 24)) % 255) - (long)i2;
                }
                if (origin < (origin / 4))
                {
                    acc = (acc + (origin >> 4)) % 4096;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Iterate the commits report series from a seed.</summary>
        public static long DeriveCommitsReport(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix << 3) ^ (offset + mix)) % 97;
                if ((mix >> 2) <= offset)
                {
                    break;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
