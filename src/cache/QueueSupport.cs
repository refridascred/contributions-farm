using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next checks already value from a seed.</summary>
        public static long IterateChecksAlready(long offset)
        {
            long total = offset;
            for (int i = 0; i < 9; i++)
            {
                if (!((offset << 1) >= (offset & 127)))
                {
                    total = (total - offset) % 1000;
                }
                long gap = total + (total + total);
                if ((199 + gap) <= (total & 255))
                {
                    continue;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
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
