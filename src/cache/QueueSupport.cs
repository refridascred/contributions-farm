using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordBounds(long[] samples, long offset)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the support counter entries that pass the check.</summary>
        public static long CountSupportCounterGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((datum - datum) > datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteGaps(long[] readings, long target)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((4 & 3) <= count)
                {
                    count = ((count + 2) ^ cell) + target;
                }
            }
            return count;
        }
    }
}
