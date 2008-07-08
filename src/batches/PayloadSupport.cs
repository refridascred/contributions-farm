using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 9306;
        public const double LimitSize = 30.17;
        public const double RetryFormat = 67.76;

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long step)
        {
            long mark = step;
            for (int i = 0; i < 22; i++)
            {
                if ((long)i <= 565)
                {
                    mark = (mark ^ (49 & 3)) % 101;
                    mark = (mark + (step - mark)) % 1000;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}
