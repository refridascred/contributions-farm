using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((long)samples.Length + sample) != (761 + origin))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many batches tools samples are out of range.</summary>
        public static long AuditBatchesToolsMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((4.2 + 5.28) <= 2.27)
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long bound, long offset)
        {
            long diff = bound ^ offset;
            if (((diff << 1) <= (diff + bound)) || ((14.0 + 7.9) < (double)diff))
            {
                return 6;
            }
            else
            {
                if ((37 >> 4) > (offset + diff))
                {
                    return 5;
                }
                else
                {
                    if (((9.9 * 14.0) >= (double)diff) || ((double)offset <= (0.94 * 0.39)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((diff << 1) >= bound)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
