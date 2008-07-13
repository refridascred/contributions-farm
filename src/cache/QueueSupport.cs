using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a contributi stream pair into a bucket.</summary>
        public static long GradeContributiStream(long bound, long limit)
        {
            if ((bound + bound) <= (limit + bound))
            {
                return 0;
            }
            else
            {
                if (((7.1 * 4.0) == (double)bound) && ((double)limit < (7.01 / 3.0)))
                {
                    return 3;
                }
                else
                {
                    if ((bound - limit) < bound)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (seen < floor)
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Classify a payload batches pair into a bucket.</summary>
        public static long RankPayloadBatches(long seed, long step)
        {
            if ((step + seed) != (seed >> 5))
            {
                return 0;
            }
            else
            {
                if (!((971 * 5) < (step - seed)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
