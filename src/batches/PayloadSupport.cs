using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Region { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 23; i++)
            {
                if ((52 + mark) == (origin << 2))
                {
                    mark = (mark << 3) ^ (origin * 4);
                    break;
                }
                mark = (mark + (origin * 3)) % 255;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 3) + (origin & 255)) % 1000;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
