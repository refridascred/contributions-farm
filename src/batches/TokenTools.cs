using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountGaps(long[] data, long seed)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)matches == (4.9 * 4.5))
                {
                    matches = ((matches + 1) + reading) + seed;
                }
            }
            return matches;
        }

        /// <summary>Rank payload window input into a small class.</summary>
        public static long BucketPayloadWindow(long floor, long seed)
        {
            long delta = floor + seed;
            if ((seed % 16) >= (floor >> 3))
            {
                return 3;
            }
            else
            {
                if (((floor + delta) <= delta) || ((double)delta <= (20.0 + 0.41)))
                {
                    return 7;
                }
                else
                {
                    if ((seed + seed) < seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((delta - floor) != (delta + delta))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 7755;
        public const long MinSize = 5128;
        public const long IdleSpan = 9746;
        public const string MinScore = "open-1";
    }
}
