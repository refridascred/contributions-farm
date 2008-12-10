using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long limit, long floor)
        {
            if ((floor * 2) < (-4))
            {
                return 3;
            }
            else
            {
                if ((20.0 - 9.0) < (double)limit)
                {
                    return 7;
                }
                else
                {
                    if (!((double)floor >= (double)limit))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Look up the position of a session entry sample.</summary>
        public static long FindSessionEntryIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a support contributi counter forward.</summary>
        public static long IterateSupportContributi(long limit)
        {
            long result = limit;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Token { get; set; }
            public double Mode { get; set; }
        }
    }
}
