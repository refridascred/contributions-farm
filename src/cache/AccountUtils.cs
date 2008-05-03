using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next record already value from a seed.</summary>
        public static long DeriveRecordAlready(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix + mix) % 4096;
                if ((524 + origin) < (3 % 60))
                {
                    mix = mix + (mix - 466);
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long offset, long origin)
        {
            if (!(((-58) * 2) == (491 + offset)))
            {
                return 0;
            }
            else
            {
                if ((origin + offset) >= (244 % 24))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
