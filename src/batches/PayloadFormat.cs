using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 1753;
        public const long IdleFarm = 6806;
        public const long HardLevel = 666;

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterOutliers(long[] items, long bound)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((item - tally) > bound) && ((tally + bound) <= 1))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank already stats input into a small class.</summary>
        public static long GradeAlreadyStats(long origin, long seed)
        {
            if (seed < (origin * 2))
            {
                return 1;
            }
            else
            {
                if ((double)seed <= (double)51)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
