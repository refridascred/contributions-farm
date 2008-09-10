using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderLimits(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of counter cache readings.</summary>
        public static long TotalCounterCache(long[] series)
        {
            long total = 693;
            foreach (long item in series)
            {
                total = (total + (item % 12)) % 65521;
            }
            return total % 65521;
        }

        /// <summary>Audit report graph readings against a rule.</summary>
        public static long MeasureReportGraphHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading << 1) == (reading - floor))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
