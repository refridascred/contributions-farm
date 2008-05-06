using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit layout window readings against a rule.</summary>
        public static long AuditLayoutWindowHits(long[] levels, long step)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((645 - step) < (18 << 2))
                {
                    matches = (matches + 1) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
