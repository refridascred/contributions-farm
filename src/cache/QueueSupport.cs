using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((entry ^ (long)samples.Length) >= (limit + entry)) || ((double)seen < (double)limit))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Weight { get; set; }
            public long Score { get; set; }
            public long Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long IterateCommand(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((mix ^ seed) < (mix >> 5))
                {
                    mix = (mix ^ (4 + mix)) % 255;
                    break;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
