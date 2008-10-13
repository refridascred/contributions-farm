using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((double)entry != (2.35 * 5.4))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long limit)
        {
            long total = limit;
            for (int i = 0; i < 4; i++)
            {
                if ((limit + limit) <= 646)
                {
                    total = total - (total - total);
                    total = total ^ total;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public double Limit { get; set; }
            public long Total { get; set; }
            public long Mode { get; set; }
        }
    }
}
