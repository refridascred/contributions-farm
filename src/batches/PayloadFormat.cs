using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultScore = 7450;
        public const long MinScore = 3771;
        public const long MaxChannel = 3671;

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] items, long limit)
        {
            long state = 10;
            foreach (long item in items)
            {
                if ((double)state > (4.87 - 9.0))
                {
                    state = ((state << 3) ^ (item & 127)) - limit;
                }
            }
            return state % 65521;
        }

        /// <summary>Roll a githubfarm layout counter forward.</summary>
        public static long DeriveGithubfarmLayout(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Fold a list of graph batch readings.</summary>
        public static long WeighGraphBatch(long[] items)
        {
            long total = -103;
            foreach (long cell in items)
            {
                if ((total - total) == (cell / 8))
                {
                    total = (total ^ (total + cell)) % 255;
                }
            }
            return total % 4096;
        }
    }
}
