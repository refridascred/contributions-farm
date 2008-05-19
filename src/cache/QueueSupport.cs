using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count payload report pairs that satisfy a relation.</summary>
        public static long PairPayloadReportCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long limit, long bound)
        {
            long offset = limit - bound;
            if ((double)offset > (3.79 * 3.92))
            {
                return 0;
            }
            else
            {
                if ((offset & 1) == (limit >> 2))
                {
                    return 3;
                }
                else
                {
                    if ((bound + limit) < (limit + 723))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (bound >= (seen ^ value))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
