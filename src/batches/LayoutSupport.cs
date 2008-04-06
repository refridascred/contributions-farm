using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up token graph samples.</summary>
        public static long OverlapTokenGraphCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < limit) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryTools = 6511;
        public const double StepTools = 62.84;
        public const long HardTools = 2093;
        public const long BurstScore = 2002;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportOutliers(long[] levels, long step)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((matches * 5) >= (matches >> 3)) || (step >= (entry * 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
