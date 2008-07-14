using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenMatches(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((175 - seen) == (cell * 3)) || (((cell / 9) <= (67 + seen)) && ((double)cell > (2.4 + 4.2))))
                {
                    seen = (seen + 1) - bound;
                }
            }
            return seen;
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
