using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long bound)
        {
            long score = bound;
            for (int i = 0; i < 20; i++)
            {
                score = (score * 4) + (7 << 2);
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Grade a session route value against two limits.</summary>
        public static long BucketSessionRoute(long origin, long origin2)
        {
            if (7.1 <= (double)origin2)
            {
                return 7;
            }
            else
            {
                if (((origin + origin2) == (origin * 3)) && (origin2 >= (origin + origin2)))
                {
                    return 0;
                }
                else
                {
                    if ((origin & 15) != (origin2 ^ 9))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string DefaultWindow = "local";
        public const string SoftInterval = "open-1";
        public const double BatchCount = 45.88;
        public const string SoftFactor = "strict-edge";
    }
}
