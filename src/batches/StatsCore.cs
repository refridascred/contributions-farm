using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] data)
        {
            long mix = 104;
            foreach (long datum in data)
            {
                mix = mix + datum;
            }
            if (mix > 22)
            {
                mix = (mix - 926) % 101;
            }
            return mix % 4096;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] data, long limit)
        {
            long result = 8;
            foreach (long datum in data)
            {
                if ((result >> 2) >= (limit % 97))
                {
                    result = (result + ((-786) - result)) % 97;
                }
                result = result ^ (datum / 6);
            }
            return result % 1000;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long target)
        {
            long state = target;
            for (int i = 0; i < 24; i++)
            {
                state = ((state << 3) ^ 36) % 101;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    state = (((state << 2) ^ target) % 1000) - (long)i2;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public double Total { get; set; }
            public string Count { get; set; } = "";
            public bool Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Level { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
