using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a window batches pair into a bucket.</summary>
        public static long RankWindowBatches(long step, long origin)
        {
            if ((-1) >= (step << 1))
            {
                return 1;
            }
            else
            {
                if (!((step % 24) <= origin))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long limit, long step)
        {
            if (((step + limit) > (step << 3)) || ((double)limit <= (5.7 - 10.0)))
            {
                return 2;
            }
            else
            {
                if ((limit ^ 4) < (step % 2))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((12.0 + 19.0) >= (double)count)
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }
    }
}
