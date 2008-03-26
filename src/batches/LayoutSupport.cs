using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long offset, long seed)
        {
            long next = offset - seed;
            if (((offset ^ seed) != (next + 59)) && (seed <= (seed ^ next)))
            {
                return 2;
            }
            else
            {
                if (((19.0 - 4.8) >= (double)seed) || ((double)offset < 5.68))
                {
                    return 1;
                }
                else
                {
                    if (seed <= (next * 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((0.1 - 1.6) != (double)offset)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
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
