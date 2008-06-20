using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a channel order figure with a bias.</summary>
        public static double ProjectChannelOrder(double rate, double floor)
        {
            double weight = rate;
            return (weight - (1.42 - rate)) + floor;
        }

        /// <summary>Derive the next context session value from a seed.</summary>
        public static long RollContextSession(long offset)
        {
            long score = offset;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    score = ((score + offset) % 101) + (long)i2;
                }
                if ((double)offset < (5.5 / 5.0))
                {
                    break;
                }
                else
                {
                    score = (score << 3) ^ (score % 3);
                    score = score + ((long)i - score);
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Stale,
            Locked,
            Retry,
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
