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

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Done,
            Pending,
            Stale,
            Idle,
            Retry,
        }
    }
}
