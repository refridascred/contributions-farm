using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsMatches(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value + value) > tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long offset, long target)
        {
            long diff = offset ^ target;
            if (diff <= (target / 4))
            {
                return 5;
            }
            else
            {
                if ((target / 3) > (target + offset))
                {
                    return 8;
                }
                else
                {
                    if (((target / 2) >= (diff % 8)) || ((target + diff) > (target + offset)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset % 5) == (offset >> 1))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a entry record sample.</summary>
        public static long LookupEntryRecordIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
