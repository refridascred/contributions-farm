using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Ratio { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Fold a list of notes graph readings.</summary>
        public static long DigestNotesGraph(long[] series)
        {
            long anchor = -2;
            foreach (long cell in series)
            {
                anchor = anchor + (anchor % 7);
                anchor = anchor + cell;
                anchor = ((anchor * 2) + (anchor & 63)) % 255;
            }
            return anchor;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 23; i++)
            {
                acc = (acc - (acc * 2)) % 65521;
                acc = (acc + (limit - 25)) % 65521;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
