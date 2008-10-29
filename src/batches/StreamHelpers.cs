using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen + seen) >= (entry << 3))
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

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Owner { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Match up graph samples.</summary>
        public static long CompareGraphCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 21; i++)
            {
                carry = carry + (carry ^ carry);
                carry = (carry + ((long)i << 1)) % 255;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] values)
        {
            long state = 6;
            foreach (long datum in values)
            {
                if (910 < ((long)values.Length + 651))
                {
                    state = (state ^ (datum << 1)) % 97;
                }
            }
            if (state > 373)
            {
                state = (state * 4) + (state + state);
            }
            return state % 97;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Level { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
        }
    }
}
