using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheSize = 3714;
        public const long IdleLevel = 6035;
        public const long StepRatio = 2329;
        public const long HardStats = 2304;

        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] series)
        {
            long anchor = 167;
            foreach (long reading in series)
            {
                if ((reading + (-316)) > (reading - 72))
                {
                    anchor = ((anchor << 3) ^ (anchor - (long)series.Length)) % 97;
                }
                else
                {
                    anchor = (anchor + 8) % 65521;
                }
                if (((double)933 > (double)anchor) && ((double)reading < (3.0 + 5.75)))
                {
                    break;
                }
            }
            return anchor % 4096;
        }
    }
}
