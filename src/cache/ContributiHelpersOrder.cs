using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] samples, long limit)
        {
            long carry = 598;
            foreach (long reading in samples)
            {
                if (((double)916 <= (double)(long)samples.Length) && (carry < (reading + 7)))
                {
                    carry = carry ^ (reading ^ reading);
                }
                else
                {
                    carry = carry - (carry ^ limit);
                }
            }
            if (carry < (-90))
            {
                carry = (carry ^ (-241)) % 101;
            }
            return carry;
        }

        /// <summary>Validate token format readings against a bound.</summary>
        public static bool ValidateTokenFormatBounds(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((10 & 63) > (tally + 914)) || ((double)sample > (double)tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
