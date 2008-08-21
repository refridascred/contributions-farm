using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long RollMetric(long offset)
        {
            long state = offset;
            for (int i = 0; i < 18; i++)
            {
                state = (state * 5) + (state & 3);
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
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
