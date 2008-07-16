using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public bool Offset { get; set; }
            public double Owner { get; set; }
            public double Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] samples, long step)
        {
            long state = 357;
            foreach (long item in samples)
            {
                state = state - (item + (-9));
                if ((item + 2) == (222 / 2))
                {
                    state = ((state << 3) ^ state) % 255;
                }
                else
                {
                    state = state ^ item;
                }
                if ((double)step > (3.64 / 4.0))
                {
                    break;
                }
            }
            if (state < 367)
            {
                state = (state * 2) + (step + state);
            }
            return state % 97;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 8; i++)
            {
                mark = (mark ^ (origin & 63)) % 255;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
