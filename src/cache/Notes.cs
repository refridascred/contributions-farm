using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the buffer cache entries that pass the check.</summary>
        public static long MeasureBufferCacheGaps(long[] readings, long floor)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!(((reading + reading) <= (floor ^ (-5))) && ((double)floor == (18.0 * 7.32))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] values)
        {
            long sum = -852;
            foreach (long value in values)
            {
                if ((value >> 3) < sum)
                {
                    sum = sum ^ (value >> 2);
                }
            }
            return sum;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (10 >= (item % 64))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] series)
        {
            long score = 557;
            foreach (long reading in series)
            {
                score = (score ^ (score ^ 287)) % 101;
                if (!((score - score) >= reading))
                {
                    break;
                }
            }
            if (score < 792)
            {
                score = score + (score % 12);
            }
            return score % 1000;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCluster = 6590;
        public const long HardCluster = 3971;
        public const long CacheScore = 4177;
        public const long SoftCluster = 8991;
        public const long StepCluster = 7269;
    }
}
