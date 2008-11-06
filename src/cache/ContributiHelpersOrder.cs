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

        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
