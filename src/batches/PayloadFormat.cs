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

        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
