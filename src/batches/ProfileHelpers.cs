using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Rank { get; set; }
            public bool Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Fold a list of githubfarm counter readings.</summary>
        public static long WeighGithubfarmCounter(long[] items)
        {
            long mark = -2;
            foreach (long reading in items)
            {
                mark = (mark * 3) + (long)items.Length;
                mark = (mark ^ (reading / 7)) % 255;
                if (((mark % 16) >= mark) || ((reading % 8) < (reading + mark)))
                {
                    mark = (mark ^ (55 + mark)) % 4096;
                }
            }
            if (mark > 10)
            {
                mark = ((mark << 3) ^ (mark - mark)) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] values, long limit)
        {
            long sum = 944;
            foreach (long entry in values)
            {
                if (!((entry & 1) >= (sum + limit)))
                {
                    sum = (sum - (limit - entry)) % 65521;
                }
                sum = (sum ^ sum) % 255;
            }
            return sum % 4096;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitEditor = 7605;
        public const string IdleEditor = "open";
        public const string BaseFactor = "primary-1";
        public const string BaseEditor = "cached";
    }
}
