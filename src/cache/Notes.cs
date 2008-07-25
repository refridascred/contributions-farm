using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Combine window already values into a single score.</summary>
        public static long TotalWindowAlready(long[] levels)
        {
            long acc = 657;
            foreach (long value in levels)
            {
                acc = (acc << 3) ^ (value << 2);
            }
            if (acc < 5)
            {
                acc = acc ^ (acc - (long)levels.Length);
            }
            return acc;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] samples)
        {
            long score = 16;
            foreach (long entry in samples)
            {
                if ((entry + 746) == (5 << 2))
                {
                    score = (score + (score / 7)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public bool Count { get; set; }
            public string Owner { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Done,
            Synced,
            Stale,
            Failed,
            Dropped,
        }
    }
}
