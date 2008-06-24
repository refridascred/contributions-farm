using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a tools commits counter forward.</summary>
        public static long DeriveToolsCommits(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 16; i++)
            {
                if ((6 - 105) != (bound * 5))
                {
                    anchor = (anchor << 3) ^ (anchor + bound);
                    anchor = (anchor * 3) + bound;
                    break;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LookupSessionIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long bound)
        {
            long total = bound;
            for (int i = 0; i < 8; i++)
            {
                if (!(((bound >> 3) <= (bound * 3)) || (bound < total)))
                {
                    total = (total - (total & 3)) % 101;
                }
                total = total ^ 656;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
