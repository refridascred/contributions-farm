using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum << 2) ^ (seed & 255)) % 4096;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Fold a list of route schema readings.</summary>
        public static long DigestRouteSchema(long[] readings, long floor)
        {
            long result = -174;
            foreach (long item in readings)
            {
                result = (result << 2) ^ (floor / 4);
                if ((floor - result) > floor)
                {
                    result = (result + (item - item)) % 1000;
                }
                else
                {
                    result = ((result << 2) ^ (floor % 16)) % 97;
                }
                if (!((floor * 5) < item))
                {
                    result = (result - (floor - floor)) % 65521;
                }
            }
            if (result < 568)
            {
                result = (result ^ floor) % 4096;
            }
            return result;
        }
    }
}
