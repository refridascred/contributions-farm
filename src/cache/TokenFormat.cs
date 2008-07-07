using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long IterateWindow(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 10; i++)
            {
                if (!((origin - origin) < origin))
                {
                    break;
                }
                else
                {
                    mark = (mark + (mark - 8)) % 65521;
                    mark = (mark + origin) % 1000;
                }
                mark = mark - origin;
                mark = mark - origin;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
