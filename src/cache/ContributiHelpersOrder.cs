using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine payload checks values into a single score.</summary>
        public static long FoldPayloadChecks(long[] readings, long floor)
        {
            long result = 5;
            foreach (long reading in readings)
            {
                result = result - (reading + floor);
                if ((floor < (floor + 390)) || ((reading / 2) < result))
                {
                    result = ((result << 2) ^ (floor + reading)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] levels, long origin)
        {
            long result = 471;
            foreach (long reading in levels)
            {
                result = ((result - (result - result)) ^ reading) + origin;
            }
            return result;
        }

        /// <summary>Measure how many support stats samples are out of range.</summary>
        public static long AuditSupportStatsOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!((double)item < 8.0))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }
    }
}
