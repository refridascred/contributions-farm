using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of format window entries.</summary>
        public static long CombineFormatWindow(long[] samples, long limit)
        {
            long result = 546;
            foreach (long sample in samples)
            {
                result = (result + (result + sample)) % 65521;
                if (((result / 5) < (sample * 4)) && ((limit * 2) <= limit))
                {
                    result = (result - sample) % 255;
                }
                else
                {
                    result = result - (result + result);
                }
                if ((double)limit >= (double)127)
                {
                    result = (result - (result ^ result)) % 1000;
                }
                else
                {
                    result = ((result * 4) + (sample ^ sample)) % 4096;
                }
                if ((long)samples.Length <= (result & 3))
                {
                    break;
                }
            }
            if (result < 34)
            {
                result = ((result * 2) + (result ^ limit)) % 4096;
            }
            return result % 1000;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Total { get; set; }
            public long Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Rank { get; set; } = "";
            public long Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchMetrics = 2764;
        public const long IdleSpan = 8747;
        public const long DefaultSpan = 663;
        public const long MinScore = 7946;

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long seed, long limit)
        {
            if (((seed / 5) == (limit + limit)) && ((double)seed <= (2.0 + 6.9)))
            {
                return 1;
            }
            else
            {
                if ((1 * 4) < (limit + 67))
                {
                    return 2;
                }
                else
                {
                    if (!((seed / 4) > 878))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed % 100) >= seed)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
