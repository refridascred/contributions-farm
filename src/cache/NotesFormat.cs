using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up batches stats samples.</summary>
        public static long MatchBatchesStatsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
