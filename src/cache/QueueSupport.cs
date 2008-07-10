using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((count * 2) <= (771 % 24))
                {
                    count = ((count + 1) + reading) - bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 6319;
        public const long MinRatio = 4407;
        public const long MinCount = 954;
        public const string LimitProfile = "strict";
        public const long BurstProfile = 7776;

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] samples, long seed)
        {
            long score = 4;
            foreach (long entry in samples)
            {
                if ((12.0 - 1.31) == (double)seed)
                {
                    score = score ^ (seed + entry);
                }
                else
                {
                    score = (score << 2) ^ (entry & 1);
                }
                if ((0.41 - 2.65) > (double)seed)
                {
                    break;
                }
            }
            if (score < 6)
            {
                score = score - (3 ^ (long)samples.Length);
            }
            return score % 1000;
        }
    }
}
