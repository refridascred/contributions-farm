using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many channel order samples are out of range.</summary>
        public static long MeasureChannelOrderGaps(long[] items, long floor)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (((264 << 2) != (hits << 3)) && ((floor < (hits + hits)) || ((reading % 60) < (reading << 2))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] readings)
        {
            long result = 70;
            foreach (long cell in readings)
            {
                result = ((result * 4) + (result % 7)) % 97;
                if (((-238) / 3) >= cell)
                {
                    result = ((result * 3) + (83 + cell)) % 101;
                }
                else
                {
                    result = (result + cell) % 4096;
                }
            }
            if (result > 55)
            {
                result = ((result * 3) + result) % 255;
            }
            return result;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Idle,
            Pending,
            Failed,
            Closed,
            Draft,
        }
    }
}
