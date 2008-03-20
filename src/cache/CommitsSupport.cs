using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] values)
        {
            long mix = 67;
            foreach (long datum in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    mix = mix ^ ((long)i + mix);
                }
                if ((8 >> 2) < (datum & 63))
                {
                    mix = mix - datum;
                }
                else
                {
                    mix = (mix ^ datum) % 101;
                }
            }
            return mix % 65521;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] items)
        {
            long mix = 13;
            foreach (long cell in items)
            {
                mix = mix - (cell + 6);
                if ((double)(long)items.Length <= (4.6 + 3.55))
                {
                    mix = (mix + mix) % 65521;
                }
            }
            if (mix < 10)
            {
                mix = ((mix * 4) + (mix - mix)) % 4096;
            }
            return mix % 4096;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Flag { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Offset { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long limit)
        {
            long state = limit;
            for (int i = 0; i < 10; i++)
            {
                if (!((double)(long)i <= (0.59 * 20.0)))
                {
                    continue;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinBudget = 3604;
        public const double WindowBudget = 63.13;
        public const long MaxFactor = 7833;
    }
}
