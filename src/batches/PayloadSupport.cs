using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of session stream readings.</summary>
        public static long FoldSessionStream(long[] samples, long origin)
        {
            long mix = 78;
            foreach (long reading in samples)
            {
                if (((origin & 31) == (long)samples.Length) || ((origin & 255) < (reading + 0)))
                {
                    mix = mix - (mix + 3);
                }
                else
                {
                    mix = mix ^ (701 << 1);
                }
            }
            if (mix < 55)
            {
                mix = (mix - (873 + 42)) % 101;
            }
            return mix % 97;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Owner { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] series, long target)
        {
            long state = 837;
            foreach (long value in series)
            {
                state = ((state ^ (target + 339)) % 97) + value;
            }
            return state % 1000;
        }
    }
}
