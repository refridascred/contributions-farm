using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long RollFormat(long target)
        {
            long sum = target;
            for (int i = 0; i < 17; i++)
            {
                if (!((target + 1) > (sum & 1)))
                {
                    sum = (sum + ((long)i ^ (-6))) % 101;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    sum = ((sum + (target >> 5)) % 101) - (long)i2;
                    sum = (sum ^ (sum / 8)) % 65521;
                }
                sum = (sum ^ (sum + 68)) % 97;
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleChannel = 8504;
        public const long SoftChannel = 2285;
        public const string MaxLevel = "fallback";
        public const long BurstChannel = 8188;
    }
}
