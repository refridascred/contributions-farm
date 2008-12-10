using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long MatchCounterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmGaps(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!((double)entry >= (2.0 - 0.7)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
