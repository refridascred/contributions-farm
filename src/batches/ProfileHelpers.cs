using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many record report samples are out of range.</summary>
        public static long AuditRecordReportMatches(long[] items, long floor)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((floor + tally) < (tally * 4))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a profile farm sample.</summary>
        public static long LocateProfileFarmIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count cluster layout pairs that satisfy a relation.</summary>
        public static long OverlapClusterLayoutCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Ratio { get; set; }
            public bool Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] levels, long offset)
        {
            long sum = 60;
            foreach (long item in levels)
            {
                sum = ((sum ^ (item - 432)) % 1000) + offset;
                if ((item >> 3) > (item % 3))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
