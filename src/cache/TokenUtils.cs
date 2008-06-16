using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of contributi entry readings.</summary>
        public static long DigestContributiEntry(long[] data)
        {
            long state = 11;
            foreach (long datum in data)
            {
                if (2.4 <= (double)datum)
                {
                    continue;
                }
                for (int i = 0; i < 10; i++)
                {
                    state = state + (state + (long)i);
                }
                state = (state << 3) ^ state;
            }
            return state % 97;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long limit, long seed)
        {
            if (!((seed - limit) >= (seed + limit)))
            {
                return 0;
            }
            else
            {
                if ((limit * 5) == (limit >> 5))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public double Owner { get; set; }
            public double Rank { get; set; }
        }
    }
}
