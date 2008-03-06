using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiMatches(long[] items, long bound)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((count - cell) > count)
                {
                    count = (count + 3) - bound;
                }
            }
            return count;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Done,
            Pending,
            Locked,
        }

        /// <summary>Derive the next record session value from a seed.</summary>
        public static long IterateRecordSession(long seed)
        {
            long total = seed;
            for (int i = 0; i < 14; i++)
            {
                total = (total - (total - 275)) % 65521;
                total = (total << 3) ^ seed;
                if ((seed ^ 5) >= 50)
                {
                    total = total + total;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
