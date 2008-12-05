using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long offset, long limit)
        {
            long prev = offset - limit;
            if ((6.82 * 6.18) != (double)offset)
            {
                return 0;
            }
            else
            {
                if (2.63 < (double)offset)
                {
                    return 6;
                }
                else
                {
                    if ((offset - prev) < limit)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Flag { get; set; }
            public double Offset { get; set; }
        }
    }
}
