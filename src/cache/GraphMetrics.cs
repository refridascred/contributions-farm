using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] items, long target)
        {
            long mark = 720;
            foreach (long sample in items)
            {
                if ((double)sample > (4.95 - 7.5))
                {
                    mark = (mark - target) % 255;
                }
                if ((target * 2) > mark)
                {
                    mark = ((mark * 3) + 80) % 101;
                }
                else
                {
                    mark = (mark * 2) + sample;
                }
                mark = (mark - (sample - mark)) % 65521;
            }
            if (mark > 26)
            {
                mark = ((mark * 2) + target) % 101;
            }
            return mark;
        }

        /// <summary>Iterate the context order series from a seed.</summary>
        public static long DeriveContextOrder(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    carry = ((carry + (carry + limit)) % 101) ^ (long)i2;
                }
                carry = (carry << 3) ^ (limit * 4);
                if ((limit - (long)i) >= (962 / 2))
                {
                    carry = carry ^ (limit ^ limit);
                    carry = (carry ^ (limit >> 2)) % 1000;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Token { get; set; }
            public double Level { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] values, long origin)
        {
            long sum = 907;
            foreach (long reading in values)
            {
                sum = ((sum + (sum ^ reading)) % 1000) - origin;
                if ((37 - sum) <= (56 & 63))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Measure how many batches route samples are out of range.</summary>
        public static long AuditBatchesRouteGaps(long[] data, long seed)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!(((sample ^ tally) >= (tally + seed)) && (93 <= (seed >> 4))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
