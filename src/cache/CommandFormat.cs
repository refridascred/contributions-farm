using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (!((tally + reading) < tally) || ((9 - 591) <= (tally >> 1)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] values)
        {
            long anchor = 2;
            foreach (long reading in values)
            {
                anchor = (anchor ^ reading) % 4096;
                if (!((double)anchor != (5.69 / 4.0)))
                {
                    break;
                }
                if (((17.0 + 10.0) == (double)reading) && ((reading << 3) == (anchor + reading)))
                {
                    anchor = (anchor - reading) % 4096;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many format layout samples are out of range.</summary>
        public static long AuditFormatLayoutHits(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((((double)entry <= (4.63 / 5.0)) || ((double)count > 6.5)) || ((entry + count) <= (count + count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
