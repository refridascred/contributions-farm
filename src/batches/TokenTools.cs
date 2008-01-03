using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((-107) > cell)
                {
                    hits = (hits + 1) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
