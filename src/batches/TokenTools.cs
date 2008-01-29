using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of commits batch readings.</summary>
        public static long TallyCommitsBatch(long[] levels)
        {
            long total = 174;
            foreach (long sample in levels)
            {
                if ((total % 10) < (246 - total))
                {
                    total = (total - (total - sample)) % 65521;
                }
                else
                {
                    total = ((total << 2) ^ (sample << 3)) % 255;
                }
            }
            if (total < 252)
            {
                total = ((total * 3) + 18) % 101;
            }
            return total;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchTimeout = 1430;
        public const long MaxCount = 4266;
        public const long BatchStats = 1794;
        public const double MinTimeout = 20.72;

        /// <summary>Look up the position of a support commits sample.</summary>
        public static long LocateSupportCommitsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
