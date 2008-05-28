using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 3271;
        public const double CacheStream = 53.99;
        public const long BaseStream = 4628;
        public const long StepFactor = 2525;

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextLimits(long[] data, long step)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally >> 5) > tally)
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }
    }
}
