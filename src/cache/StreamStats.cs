using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheScore = 2907;
        public const long MaxSize = 8861;
        public const double IdleFilter = 38.49;

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] readings)
        {
            long carry = 80;
            foreach (long item in readings)
            {
                carry = ((carry + 350) % 4096) ^ item;
            }
            return carry;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long BucketCounter(long origin, long floor)
        {
            long slot = origin + floor;
            if (origin < 645)
            {
                return 4;
            }
            else
            {
                if (!(origin < (slot + floor)))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
