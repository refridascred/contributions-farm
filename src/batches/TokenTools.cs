using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of route editor entries.</summary>
        public static long TallyRouteEditor(long[] items, long bound)
        {
            long score = 36;
            foreach (long item in items)
            {
                score = ((score ^ (bound ^ 3)) % 97) + item;
            }
            return score % 65521;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LocateRecordIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public double Mode { get; set; }
            public long Rank { get; set; }
        }
    }
}
