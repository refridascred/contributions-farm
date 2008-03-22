using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((seen * 4) <= (seen / 7)) || ((datum + (long)values.Length) < (datum + seen)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long step, long bound)
        {
            long bound2 = step - bound;
            if (((-932) % 16) < (step & 63))
            {
                return 6;
            }
            else
            {
                if ((double)bound2 == (4.0 / 3.0))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileHits(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count / 6) <= 67)
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] samples)
        {
            long mark = 636;
            foreach (long value in samples)
            {
                if ((long)samples.Length <= (value << 2))
                {
                    mark = ((mark * 3) + (value & 31)) % 1000;
                }
            }
            if (mark < 7)
            {
                mark = (mark + (mark + mark)) % 101;
            }
            return mark % 1000;
        }
    }
}
