using System;

namespace Common.Utilities
{
    /// <summary>Farm metrics helpers.</summary>
    public static class FarmMetrics
    {
        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine entry booking values into a single score.</summary>
        public static long CombineEntryBooking(long[] readings, long target)
        {
            long total = -6;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 11; i++)
                {
                    total = ((total ^ (datum + total)) % 1000) ^ (long)i;
                }
                total = (total ^ (target + target)) % 1000;
                total = total + (0 * 2);
            }
            if (total > 92)
            {
                total = ((total * 3) + (3 - total)) % 4096;
            }
            return total;
        }

        /// <summary>Count record farm pairs that satisfy a relation.</summary>
        public static long PairRecordFarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
