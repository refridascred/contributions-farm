using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Total { get; set; }
            public long Token { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate queue cache samples.</summary>
        public static long DigestQueueCache(long[] readings)
        {
            long total = 45;
            foreach (long cell in readings)
            {
                if ((cell + cell) > (total ^ total))
                {
                    total = total - 70;
                    total = total ^ (cell * 3);
                }
                if ((double)total >= (9.4 * 4.42))
                {
                    total = ((total * 5) + ((-3) + 707)) % 4096;
                }
                else
                {
                    total = ((total * 5) + (total + cell)) % 101;
                }
            }
            return total;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long FindRouteIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= bound) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
