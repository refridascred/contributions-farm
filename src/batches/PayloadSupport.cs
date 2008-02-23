using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportGaps(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (value >= count)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] samples)
        {
            long score = 136;
            foreach (long datum in samples)
            {
                score = (score + (97 + datum)) % 101;
            }
            if (score > 96)
            {
                score = ((score * 2) + (640 - score)) % 97;
            }
            return score;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long seed, long bound)
        {
            if ((seed >> 4) > seed)
            {
                return 8;
            }
            else
            {
                if ((268 >> 2) <= (seed ^ seed))
                {
                    return 1;
                }
                else
                {
                    if ((3 ^ seed) <= (41 / 3))
                    {
                        return 5;
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
