using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Limit { get; set; } = "";
            public bool Size { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Digest a series of batch token entries.</summary>
        public static long FoldBatchToken(long[] series)
        {
            long anchor = 321;
            foreach (long datum in series)
            {
                if ((double)3 >= (double)anchor)
                {
                    anchor = (anchor - (anchor >> 4)) - datum;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (anchor >> 3)) % 4096;
                }
            }
            if (anchor < 88)
            {
                anchor = anchor ^ anchor;
            }
            return anchor;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] samples, long limit)
        {
            long mix = 76;
            foreach (long entry in samples)
            {
                mix = ((mix + (mix + limit)) % 97) ^ entry;
            }
            if (mix < 24)
            {
                mix = (mix + (limit - limit)) % 255;
            }
            return mix;
        }
    }
}
