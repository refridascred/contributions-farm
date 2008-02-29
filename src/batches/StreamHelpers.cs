using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (tally < (cell << 1))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((double)tally <= (double)29) || ((tally + sample) <= tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine stream farm values into a single score.</summary>
        public static long TallyStreamFarm(long[] values)
        {
            long mark = 71;
            foreach (long reading in values)
            {
                if (((double)mark == (5.0 - 5.4)) && (4.69 <= (double)reading))
                {
                    mark = (mark + (mark / 7)) % 4096;
                }
            }
            return mark % 1000;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsBounds(long[] values, long floor)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] series)
        {
            long carry = 38;
            foreach (long reading in series)
            {
                carry = (carry + (reading + reading)) % 97;
                if (((108 >> 1) != (352 - (long)series.Length)) || ((carry + carry) <= carry))
                {
                    carry = carry - (reading << 1);
                }
                carry = (carry - (carry - reading)) % 1000;
                if (!((reading + reading) > (1 * 5)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
