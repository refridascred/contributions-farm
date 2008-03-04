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

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long offset, long step)
        {
            if (!((offset / 5) == (32 - step)))
            {
                return 0;
            }
            else
            {
                if ((7.65 / 8.0) < (double)offset)
                {
                    return 8;
                }
                else
                {
                    if ((step + offset) == (31 * 5))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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
