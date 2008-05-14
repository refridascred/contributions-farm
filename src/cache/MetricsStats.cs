using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] levels, long step)
        {
            long mix = 53;
            foreach (long entry in levels)
            {
                mix = ((mix + (step + mix)) % 101) + entry;
                for (int i = 0; i < 2; i++)
                {
                    long bound = mix & 15;
                    mix = (((mix * 2) + (mix + bound)) % 97) + (long)i;
                }
                if ((1.9 + 7.38) > (8.7 * 6.0))
                {
                    mix = mix ^ (mix >> 3);
                }
                else
                {
                    mix = (mix << 3) ^ mix;
                }
            }
            return mix;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public string Limit { get; set; } = "";
            public bool Count { get; set; }
            public double Flag { get; set; }
            public double Region { get; set; }
        }
    }
}
