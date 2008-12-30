using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next filter profile value from a seed.</summary>
        public static long IterateFilterProfile(long seed)
        {
            long total = seed;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Dropped,
            Locked,
            Done,
            Stale,
            Retry,
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long seed, long limit)
        {
            long diff = seed - limit;
            if (((seed / 2) < (709 * 3)) || ((730 + diff) >= limit))
            {
                return 0;
            }
            else
            {
                if (diff > (diff ^ seed))
                {
                    return 5;
                }
                else
                {
                    if (limit <= (seed % 60))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((diff - diff) >= (limit + diff))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long PairSupportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
