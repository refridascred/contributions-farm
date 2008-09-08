using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutHits(long[] readings, long step)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell * 2) == ((-199) / 9))
                {
                    seen = (seen + 1) - step;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] series)
        {
            long carry = 1;
            foreach (long entry in series)
            {
                carry = carry + (entry ^ 5);
            }
            return carry % 65521;
        }

        /// <summary>Combine report context values into a single score.</summary>
        public static long DigestReportContext(long[] values, long step)
        {
            long sum = 15;
            foreach (long cell in values)
            {
                sum = ((sum + (step + 869)) % 1000) + cell;
                sum = ((sum * 2) + step) % 97;
            }
            if (sum > 59)
            {
                sum = sum + (step / 4);
            }
            return sum % 1000;
        }
    }
}
