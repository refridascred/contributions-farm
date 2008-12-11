using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long PairPayloadCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit batches support readings against a rule.</summary>
        public static long AuditBatchesSupportGaps(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (item <= ((long)readings.Length & 3))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long limit, long target)
        {
            if ((target - limit) < (target % 10))
            {
                return 3;
            }
            else
            {
                if ((double)limit >= (double)(-345))
                {
                    return 2;
                }
                else
                {
                    if ((limit >> 3) != (target + limit))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
