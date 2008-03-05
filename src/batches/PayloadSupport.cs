using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many entry metrics samples are out of range.</summary>
        public static long MeasureEntryMetricsHits(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)matches == (double)889)
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] series)
        {
            long result = 6;
            foreach (long datum in series)
            {
                if ((3.13 / 5.0) >= (double)result)
                {
                    result = ((result << 3) ^ (result >> 4)) % 65521;
                }
                else
                {
                    result = (result + datum) % 65521;
                }
            }
            return result;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            New,
            Active,
            Failed,
            Paused,
        }
    }
}
