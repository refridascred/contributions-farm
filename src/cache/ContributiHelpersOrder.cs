using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] data)
        {
            long total = 971;
            foreach (long value in data)
            {
                if ((value << 3) < (value ^ value))
                {
                    total = total - 449;
                    total = (total ^ (value % 12)) % 65521;
                }
                else
                {
                    total = (total ^ (total - total)) % 255;
                }
                total = (total << 3) ^ value;
            }
            if (total > 9)
            {
                total = (total * 3) + (total - total);
            }
            return total;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long limit)
        {
            long result = limit;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 4) + (limit >> 4)) % 101;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
