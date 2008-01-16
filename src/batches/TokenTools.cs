using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 2) + (anchor >> 1)) % 1000;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Match up tools cluster samples.</summary>
        public static long OverlapToolsClusterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksRange(long[] data, long bound)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
