using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsMatches(long[] samples, long offset)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count * 2) >= (offset - cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Iterate the layout entry series from a seed.</summary>
        public static long SeriesLayoutEntry(long target)
        {
            long result = target;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
