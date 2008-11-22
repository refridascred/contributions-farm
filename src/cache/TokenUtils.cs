using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long MatchClusterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of record command entries.</summary>
        public static long CombineRecordCommand(long[] readings)
        {
            long result = 738;
            foreach (long value in readings)
            {
                if ((value + result) < (result << 2))
                {
                    result = (result * 3) + (result + result);
                }
            }
            return result;
        }

        /// <summary>Look up the position of a command token sample.</summary>
        public static long LookupCommandTokenIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
