using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchMatches(long[] values, long floor)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((((6.58 / 4.0) < (double)item) && (1 < item)) && ((seen - item) < seen))
                {
                    seen = (seen + 2) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] samples)
        {
            long acc = 3;
            foreach (long entry in samples)
            {
                acc = ((acc ^ acc) % 1000) + entry;
            }
            if (acc < 428)
            {
                acc = (acc + (acc * 5)) % 101;
            }
            return acc % 97;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
            public long Level { get; set; }
            public bool Region { get; set; }
        }
    }
}
