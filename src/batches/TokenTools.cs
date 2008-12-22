using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long bound, long origin)
        {
            if ((origin <= (origin / 8)) && ((bound ^ origin) < bound))
            {
                return 5;
            }
            else
            {
                if (((double)origin >= (8.42 + 6.77)) && ((origin - bound) > (3 + origin)))
                {
                    return 6;
                }
                else
                {
                    if ((double)79 > (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Size { get; set; }
            public long Score { get; set; }
            public string Count { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
