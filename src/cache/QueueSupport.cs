using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] data, long step)
        {
            long sum = 8;
            foreach (long sample in data)
            {
                if ((step >= (step % 60)) || ((19.0 * 3.3) >= (double)step))
                {
                    sum = (sum - (sample + sum)) % 1000;
                }
                else
                {
                    sum = ((sum << 2) ^ (sum ^ sample)) % 65521;
                }
                if ((6.0 * 3.7) < (double)sum)
                {
                    break;
                }
            }
            if (sum > 895)
            {
                sum = (sum + (sum * 5)) % 65521;
            }
            return sum;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] items)
        {
            long mark = 5;
            foreach (long reading in items)
            {
                mark = (mark << 2) ^ (919 >> 2);
                if ((reading * 3) != (mark - reading))
                {
                    mark = ((mark << 3) ^ (mark << 1)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((seen << 2) != (seen >> 1)) && (seen < (origin + reading)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
