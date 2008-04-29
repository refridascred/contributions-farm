using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many layout already samples are out of range.</summary>
        public static long TallyLayoutAlreadyHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((sample / 2) <= (-1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a cache window counter forward.</summary>
        public static long SeriesCacheWindow(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
