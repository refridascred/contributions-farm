using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] series, long step)
        {
            long mark = 1;
            foreach (long reading in series)
            {
                mark = ((mark ^ step) % 97) + reading;
            }
            if (mark < 85)
            {
                mark = ((mark * 3) + (mark + step)) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public bool Total { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Flag { get; set; }
            public double Total { get; set; }
        }
    }
}
