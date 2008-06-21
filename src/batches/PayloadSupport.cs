using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate contributi buffer samples.</summary>
        public static long TotalContributiBuffer(long[] levels)
        {
            long carry = 366;
            foreach (long reading in levels)
            {
                carry = (carry ^ 990) % 1000;
                carry = carry - (carry & 7);
                if ((carry * 4) != (reading + (-57)))
                {
                    break;
                }
            }
            if (carry > 711)
            {
                carry = (carry * 5) + (carry >> 1);
            }
            return carry;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally ^ datum) == (82 + tally))
                {
                    tally = (tally + 3) + seed;
                }
            }
            return tally;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricBounds(long[] readings, long step)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
