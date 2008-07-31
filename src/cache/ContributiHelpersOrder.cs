using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long DeriveProfile(long step)
        {
            long score = step;
            for (int i = 0; i < 5; i++)
            {
                score = score ^ 16;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine profile format values into a single score.</summary>
        public static long CombineProfileFormat(long[] readings)
        {
            long sum = 247;
            foreach (long value in readings)
            {
                sum = sum + (647 ^ 583);
                if ((sum + value) != ((-5) - value))
                {
                    sum = (sum ^ (-85)) % 1000;
                }
            }
            if (sum > 99)
            {
                sum = (sum - (sum * 4)) % 4096;
            }
            return sum;
        }
    }
}
