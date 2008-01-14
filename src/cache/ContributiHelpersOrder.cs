using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long origin, long step)
        {
            if ((double)step >= (14.0 * 8.6))
            {
                return 6;
            }
            else
            {
                if ((double)step <= (17.0 + 3.0))
                {
                    return 3;
                }
                else
                {
                    if (((7.7 / 4.0) > (double)step) || ((step + origin) == (160 + step)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((((-48) ^ step) <= 285) || ((3 & 255) < (origin - origin)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
