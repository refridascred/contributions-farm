using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine profile notes values into a single score.</summary>
        public static long WeighProfileNotes(long[] readings)
        {
            long carry = 943;
            foreach (long datum in readings)
            {
                if ((datum + datum) < (datum + (long)readings.Length))
                {
                    carry = carry + (datum % 100);
                }
                else
                {
                    carry = (carry << 2) ^ (datum + 678);
                }
            }
            return carry;
        }

        /// <summary>Check that every route metrics entry stays within the limit.</summary>
        public static bool VerifyRouteMetricsRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
