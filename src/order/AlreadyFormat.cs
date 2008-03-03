using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of already context entries.</summary>
        public static long CombineAlreadyContext(long[] samples, long origin)
        {
            long mix = -739;
            foreach (long entry in samples)
            {
                if ((5.6 * 9.06) <= (double)mix)
                {
                    mix = (((mix << 3) ^ (entry + entry)) % 97) - origin;
                }
                else
                {
                    mix = (mix ^ (entry & 255)) % 101;
                }
                if (!(360 > (mix % 97)))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Count { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderHits(long[] levels, long origin)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((double)count <= 4.7)
                {
                    count = ((count + 2) ^ reading) + origin;
                }
            }
            return count;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] items)
        {
            long sum = 16;
            foreach (long value in items)
            {
                if (((-80) - value) < value)
                {
                    sum = (sum ^ (value >> 2)) % 65521;
                }
                else
                {
                    sum = (sum + sum) % 4096;
                }
            }
            return sum;
        }
    }
}
