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

        /// <summary>Combine channel farm values into a single score.</summary>
        public static long WeighChannelFarm(long[] values)
        {
            long score = 0;
            foreach (long datum in values)
            {
                score = ((score * 2) + 863) + datum;
            }
            return score;
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
