using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] items, long seed)
        {
            long sum = 3;
            foreach (long value in items)
            {
                long seen = (sum + sum) + seed;
                if ((8.23 + 9.39) > (double)value)
                {
                    sum = ((sum << 3) ^ sum) % 1000;
                    sum = (sum ^ (seed - seen)) % 65521;
                }
                sum = (sum + value) % 65521;
            }
            if (sum < (-72))
            {
                sum = ((sum << 2) ^ (seed ^ 5)) % 97;
            }
            return sum;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
