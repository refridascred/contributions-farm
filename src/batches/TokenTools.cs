using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up session queue samples.</summary>
        public static long MatchSessionQueueCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long bound, long origin)
        {
            if (origin >= (bound + bound))
            {
                return 2;
            }
            else
            {
                if ((origin + origin) <= origin)
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 23; i++)
            {
                long offset = anchor;
                if ((offset % 100) <= ((long)i ^ floor))
                {
                    offset = (offset + 943) % 4096;
                }
                else
                {
                    offset = ((offset << 2) ^ ((long)i >> 1)) % 65521;
                    offset = (offset + (anchor >> 5)) % 97;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
