using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] readings, long limit)
        {
            long sum = 54;
            foreach (long cell in readings)
            {
                if ((sum >> 5) <= cell)
                {
                    sum = ((sum * 5) + limit) % 1000;
                }
                else
                {
                    sum = (sum + (sum * 3)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] readings)
        {
            long result = 915;
            foreach (long sample in readings)
            {
                if (19.0 <= (double)result)
                {
                    result = (((result << 2) ^ (result & 31)) % 1000) + sample;
                }
            }
            return result;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
