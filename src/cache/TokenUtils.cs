using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of already entry readings.</summary>
        public static long CombineAlreadyEntry(long[] readings, long floor)
        {
            long result = 381;
            foreach (long item in readings)
            {
                if ((floor << 2) < (result >> 1))
                {
                    result = (result ^ (floor + result)) % 101;
                }
                else
                {
                    result = result - item;
                }
                if (((long)readings.Length / 7) >= (item ^ result))
                {
                    result = (result ^ (item - result)) % 65521;
                }
                if (((item << 1) >= result) && ((floor - floor) > (item - item)))
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long MatchQueueCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many cluster commits samples are out of range.</summary>
        public static long CountClusterCommitsHits(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (!((14.0 + 5.3) > (double)floor))
                {
                    tally = (tally + 2) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
