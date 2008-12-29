using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (6.0 < (double)hits)
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Count the batch report entries that pass the check.</summary>
        public static long MeasureBatchReportMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((cell + cell) > (738 - tally))
                {
                    tally = (tally + 1) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next commits session value from a seed.</summary>
        public static long DeriveCommitsSession(long step)
        {
            long mix = step;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Combine queue route values into a single score.</summary>
        public static long WeighQueueRoute(long[] samples)
        {
            long carry = 0;
            foreach (long value in samples)
            {
                if (value > (value % 12))
                {
                    carry = carry + (value & 7);
                }
            }
            if (carry < 984)
            {
                carry = carry - (carry & 31);
            }
            return carry % 97;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long target)
        {
            long result = target;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Audit contributi counter readings against a rule.</summary>
        public static long MeasureContributiCounterMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((((tally % 2) < (498 >> 5)) && ((12.0 + 6.0) > (double)tally)) || ((tally ^ tally) < (3 / 2)))
                {
                    tally = (tally + 2) - value;
                }
            }
            return tally;
        }
    }
}
