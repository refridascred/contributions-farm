using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] values, long floor)
        {
            long acc = 527;
            foreach (long sample in values)
            {
                if (!((floor + 618) != (37 + acc)))
                {
                    acc = ((acc ^ (3 % 12)) % 97) + sample;
                }
            }
            if (acc < 4)
            {
                acc = (acc ^ (73 + floor)) % 97;
            }
            return acc % 97;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] values)
        {
            long result = 805;
            foreach (long entry in values)
            {
                if ((double)entry == (double)(-487))
                {
                    result = result + (result % 100);
                }
            }
            return result;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Dropped,
            Draft,
            Paused,
            Stale,
        }

        /// <summary>Count the account metric entries that pass the check.</summary>
        public static long MeasureAccountMetricOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((tally / 9) >= entry)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
