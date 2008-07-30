using System;

namespace Common.Utilities
{
    /// <summary>Report format helpers.</summary>
    public static class ReportFormat
    {
        /// <summary>Validate graph order readings against a bound.</summary>
        public static bool CheckGraphOrderRange(long[] items, long step)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit counter graph readings against a rule.</summary>
        public static long MeasureCounterGraphHits(long[] series, long origin)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (origin >= (101 + entry))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiMatches(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((6.64 / 9.0) > (double)cell) || (((81 + cell) == (cell ^ tally)) && ((635 + tally) <= cell)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
