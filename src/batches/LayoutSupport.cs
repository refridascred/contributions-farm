using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterOutliers(long[] items, long floor)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (count > ((-125) + floor))
                {
                    count = (count + 1) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BurstToken = "strict-1";
        public const long LimitRatio = 2390;
        public const long RetryCount = 7497;
        public const long SoftToken = 4982;
        public const string RetryDepth = "latest-edge";

        /// <summary>Count layout githubfarm pairs that satisfy a relation.</summary>
        public static long PairLayoutGithubfarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next payload githubfarm value from a seed.</summary>
        public static long RollPayloadGithubfarm(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Label { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
