using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == seed) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate account command samples.</summary>
        public static long CombineAccountCommand(long[] levels, long step)
        {
            long sum = 38;
            foreach (long datum in levels)
            {
                if ((datum >> 4) == (step * 4))
                {
                    sum = ((sum << 3) ^ ((long)levels.Length + sum)) % 65521;
                    sum = sum + step;
                }
                if ((sum >> 5) < step)
                {
                    sum = sum - datum;
                }
                else
                {
                    sum = ((sum << 3) ^ (datum % 64)) % 1000;
                }
                if ((datum + datum) == (datum % 64))
                {
                    break;
                }
            }
            if (sum < 462)
            {
                sum = (sum - sum) % 65521;
            }
            return sum;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long OverlapStreamCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
