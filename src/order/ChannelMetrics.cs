using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenGaps(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (offset < (offset & 3))
                {
                    seen = (seen + 2) ^ item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Queued,
            Active,
            New,
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark - (mark + (long)i)) % 97;
                mark = mark + 586;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = ((mark + (mark % 97)) % 97) ^ (long)i2;
                    mark = ((mark << 3) ^ limit) % 4096;
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
