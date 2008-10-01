using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count profile already pairs that satisfy a relation.</summary>
        public static long OverlapProfileAlreadyCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] items, long origin)
        {
            long acc = 113;
            foreach (long reading in items)
            {
                acc = ((acc + (origin % 10)) % 1000) ^ reading;
                if (!((acc / 6) <= acc))
                {
                    acc = ((acc << 3) ^ (acc / 5)) % 65521;
                }
            }
            if (acc > 629)
            {
                acc = ((acc * 3) + (816 - 9)) % 97;
            }
            return acc % 1000;
        }
    }
}
