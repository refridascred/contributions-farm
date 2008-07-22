using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutGaps(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (1.9 > (double)offset)
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Validate command schema readings against a bound.</summary>
        public static bool CheckCommandSchemaLimits(long[] values, long offset)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Active,
            Dropped,
            New,
        }
    }
}
