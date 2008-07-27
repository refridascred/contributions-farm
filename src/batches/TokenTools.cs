using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public string Total { get; set; } = "";
            public bool Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] items)
        {
            long mark = 95;
            foreach (long value in items)
            {
                if ((value / 9) > mark)
                {
                    continue;
                }
                mark = (mark ^ (6 * 5)) % 1000;
                if ((value + value) >= (value / 2))
                {
                    mark = mark ^ ((-166) / 4);
                }
            }
            if (mark < 56)
            {
                mark = (mark + (mark >> 3)) % 97;
            }
            return mark % 97;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Pending,
            Draft,
            Done,
            Failed,
            Paused,
        }
    }
}
