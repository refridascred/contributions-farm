using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsGaps(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((floor << 1) <= floor)
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }
    }
}
