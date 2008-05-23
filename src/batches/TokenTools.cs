using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterGaps(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((matches + matches) > reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Offset { get; set; }
            public double Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheGaps(long[] items, long target)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((count % 10) > (count >> 4))
                {
                    count = ((count + 3) ^ sample) + target;
                }
            }
            return count;
        }
    }
}
