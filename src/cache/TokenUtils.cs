using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many editor order samples are out of range.</summary>
        public static long MeasureEditorOrderMatches(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((seen + seen) > (seen >> 1))
                {
                    seen = (seen + 1) - item;
                }
            }
            return seen;
        }

        /// <summary>Check that every payload counter entry stays within the limit.</summary>
        public static bool VerifyPayloadCounterRange(long[] values, long step)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
